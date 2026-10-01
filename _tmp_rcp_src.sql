SET NOCOUNT ON;

-- Count source insights that have RelevantContactPerson
SELECT 'SRC_WITH_RCP' AS k, COUNT(*) AS n
FROM dbo.BDO_Insight
WHERE RelevantContactPerson IS NOT NULL AND RelevantContactPerson <> '';

-- Distinct node ids referenced, grouped by target class
SELECT 'RCP_NODE_CLASSES' AS k, cl.ClassName, COUNT(DISTINCT t.NodeID) AS nodes, COUNT(*) AS refs
FROM dbo.BDO_Insight bi
CROSS APPLY STRING_SPLIT(bi.RelevantContactPerson, '|') ss
JOIN dbo.CMS_Tree t ON t.NodeID = TRY_CAST(LTRIM(RTRIM(ss.value)) AS int)
JOIN dbo.CMS_Class cl ON cl.ClassID = t.NodeClassID
WHERE bi.RelevantContactPerson IS NOT NULL AND bi.RelevantContactPerson <> ''
GROUP BY cl.ClassName
ORDER BY refs DESC;

-- Values that do NOT resolve to any CMS_Tree node (dangling node ids)
SELECT 'RCP_DANGLING' AS k, COUNT(*) AS refs
FROM dbo.BDO_Insight bi
CROSS APPLY STRING_SPLIT(bi.RelevantContactPerson, '|') ss
LEFT JOIN dbo.CMS_Tree t ON t.NodeID = TRY_CAST(LTRIM(RTRIM(ss.value)) AS int)
WHERE bi.RelevantContactPerson IS NOT NULL AND bi.RelevantContactPerson <> ''
  AND t.NodeID IS NULL AND LTRIM(RTRIM(ss.value)) <> '';
