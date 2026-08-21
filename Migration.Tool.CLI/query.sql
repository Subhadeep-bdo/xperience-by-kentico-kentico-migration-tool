SELECT 
    ClassName, 
    ClassDisplayName, 
    ClassContentTypeType,
    CAST(ClassFormDefinition AS NVARCHAR(MAX)) AS FormDef 
FROM CMS_Class 
WHERE CAST(ClassFormDefinition AS NVARCHAR(MAX)) LIKE '%column="title"%' 
   OR CAST(ClassFormDefinition AS NVARCHAR(MAX)) LIKE '%column="Title"%'
ORDER BY ClassName;
