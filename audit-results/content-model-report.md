# Content Model Report

## Sites

| Site | Code Name | Domain | Default Culture | All Cultures |
| ---- | --------- | ------ | --------------- | ------------ |
| Demo | `Demo` | gwttst-demo-admin.bdo.global | en-GB | en-GB, he-IL, lt-LT |
| E2E & Performance | `E2E_Performance` | gwttst-e2e-admin.bdo.global | en-GB | en-GB, he-IL, lt-LT |
| GWT BDO India team | `GWTBDOIndiaTeam` | gwttst-india-admin.bdo.global | en-GB | en-GB |
| GWT Export | `GWTExport` | gwttst-export-admin.bdo.global | en-GB | en-GB, ru-RU |
| GWT TST | `GWT_TST` | gwttst-admin.bdo.global | en-GB | ar-DZ, nl-NL, en-AU, en-GB, fi-FI, ka-GE, he-IL, ko-KR, lt-LT, nb-NO, nn-NO |
| Integrations | `Integrations` | integrations-admin.gwttst.bdo.global | en-GB | nl-NL, en-GB |
| www.bdowow.com | `Www.bdowow.com` | www-admin.bdowow.com:443 | lt-LT | en-GB, lt-LT |
| www.bdowow.global | `BDOWOW` | www-admin.bdowow.global | en-GB | en-GB, lt-LT |

### Demo

```text
/  [CMS.Root]
├── /Sitemap  [BDO.Sitemap]
├── /Section-Widget-Content  [BDO.SectionWidgetContent]
│   ├── /Section-Widget-Content/In-Focus-Folder  [BDO.InFocusFolder]
│   │   ├── /Section-Widget-Content/In-Focus-Folder/Myths-about-future  [BDO.InFocusPage]
│   │   └── /Section-Widget-Content/In-Focus-Folder/Ai-and-business  [BDO.InFocusPage]
│   └── /Section-Widget-Content/FAQ-Folder  [BDO.FaqFolder]
│       ├── /Section-Widget-Content/FAQ-Folder/Services  [BDO.FaqTopic]
│       ├── /Section-Widget-Content/FAQ-Folder/Oil  [BDO.FaqTopic]
│       │   ├── /Section-Widget-Content/FAQ-Folder/Oil/Oil-prices  [BDO.FaqPage]
│       │   ├── /Section-Widget-Content/FAQ-Folder/Oil/Prices-recovery  [BDO.FaqPage]
│       │   ├── /Section-Widget-Content/FAQ-Folder/Oil/OPEC  [BDO.FaqPage]
│       │   └── /Section-Widget-Content/FAQ-Folder/Oil/Geopolitical  [BDO.FaqPage]
│       └── /Section-Widget-Content/FAQ-Folder/FAQ-topic-about-Ai  [BDO.FaqTopic]
│           ├── /Section-Widget-Content/FAQ-Folder/FAQ-topic-about-Ai/Ai-myth  [BDO.FaqPage]
│           └── /Section-Widget-Content/FAQ-Folder/FAQ-topic-about-Ai/Authenticity-of-Ai  [BDO.FaqPage]
├── /Home  [BDO.HomePage]
│   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.TiledLinkSection, BDO.Widget.RichText
│   ├── /Home/Har-du-prøvd-ERP-kompasset  [BDO.HomeHeroSlide]
│   ├── /Home/Studie-Governance-Zu-wenig-ESG-Kompetenz-in-Aufsic  [BDO.HomeHeroSlide]
│   ├── /Home/Automotive-Sector-Update-Q3-2023  [BDO.HomeHeroSlide]
│   └── /Home/Trending-topics  [BDO.TrendingTopics]
│       └── /Home/Trending-topics/Topic-1  [BDO.TrendingTopic]
├── /About  [BDO.SectionAbout]
│   └── /About/JJ-About-Widgets  [BDO.AboutPage]
│       └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.RichText, BDO.Widget.QuoteCard
├── /Contact-us  [BDO.Contact]
├── /Search  [BDO.Search]
├── /Subscribe  [BDO.Subscribe]
│   ├── /Subscribe/Subscribe-Confirm  [BDO.SubscribeConfirm]
│   └── /Subscribe/Unsubscribe-confirm  [BDO.SubscribeRemove]
├── /Thank-you  [BDO.ThankYouConversionPages]
│   ├── /Thank-you/JJ-Thank-You-page  [BDO.ThankYouConversionPage]
│   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText
│   └── /Thank-you/Thank-you  [BDO.ThankYouConversionPage]
│       └── Widgets: BDO.Widget.RichText, BDO.Widget.Button, Kentico.FormWidget
├── /Insights  [BDO.SectionInsightsPage]
│   ├── /Insights/Insight-category  [BDO.InsightCategory]
│   ├── /Insights/Insight-with-hero  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.EditorsPick, BDO.Widget.RichText, BDO.Widget.ImageWithText, BDO.Widget.KeyContacts
│   ├── /Insights/Key-takeaways-demo  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.KeyTakeaways, BDO.Widget.Faq, BDO.Widget.InFocus
│   ├── /Insights/Matas-Demo-(1)  [BDO.Insight]
│   ├── /Insights/Matas-Demo  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.RichText
│   ├── /Insights/Demo-Widgets  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.FlexibleContent, BDO.Widget.EditorsPick, Kentico.FormWidget
│   ├── /Insights/Demo-Sections  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.RichText
│   ├── /Insights/Matas-Contributors-Demo  [BDO.Insight]
│   ├── /Insights/Exploring-possibilities-in-Finance-AI-and-Machine  [BDO.Insight]
│   ├── /Insights/Industry-Updates-A-2025-Perspective  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.EditorsPick, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts
│   ├── /Insights/Matas-Quote-demo  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.QuoteCard
│   ├── /Insights/New-Layout-Demo-Insight  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.RichText
│   ├── /Insights/Demo-Insight-without-sidebar-(1)  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.FlexibleBanner, BDO.Widget.InsightCarousel
│   ├── /Insights/Demo-Insight-without-sidebar  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.FlexibleBanner
│   ├── /Insights/Art-and-Culture-2023-2024-(1)  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.RichText
│   ├── /Insights/Art-and-Culture-2023-2024  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.RichText
│   ├── /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.FlexibleContent, BDO.Widget.Accordion, BDO.Widget.ImageWithText, BDO.Widget.InFocus
│   ├── /Insights/Automotive-Sector-Update-Q3-2023-(1)  [BDO.Insight]
│   │   └── Widgets: Kentico.FormWidget, BDO.Widget.RelatedContentCarousel
│   ├── /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-Affe  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.InsightCarousel, BDO.Widget.RichText, BDO.Widget.NewsCarousel
│   ├── /Insights/IFRB-2024-02-Amendments-to-IAS-1-–-Clarification-o  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.Button, BDO.Widget.FlexibleBanner, BDO.Widget.Accordion, BDO.Widget.NewsCarousel, BDO.Widget.Faq
│   ├── /Insights/Automotive-Sector-Update-Q3-2023  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RelatedContacts, BDO.Widget.SocialMediaButtons, BDO.Widget.RichText, Kentico.FormWidget
│   └── /Insights/Automotive-Sector-Update-Q4  [BDO.Insight]
│       └── Widgets: BDO.Widget.FlexibleContent
├── /Business-strategies  [BDO.SectionBusinessStrategies]
│   └── /Business-strategies/Business-Strategy  [BDO.BusinessStrategy]
│       └── Widgets: BDO.Widget.TabAccordion
├── /Advisory  [BDO.SectionServices]
│   ├── /Advisory/MV-Bussiness-line  [BDO.BusinessLine]
│   │   └── /Advisory/MV-Bussiness-line/MV-Ordering-demo  [BDO.ServiceArea]
│   │       └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts
│   ├── /Advisory/BDO-Consulting  [BDO.BusinessLine]
│   │   └── Widgets: BDO.Widget.EditorsPick, BDO.Widget.TabAccordion
│   └── /Advisory/Advisory  [BDO.BusinessLine]
│       └── Widgets: BDO.Widget.RichText, BDO.Widget.TabAccordion, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.InFocus, BDO.Widget.Faq
│       ├── /Advisory/Advisory/AI-Strategy-Implementation-Services  [BDO.ServiceArea]
│       ├── /Advisory/Advisory/Management-advisory  [BDO.ServiceArea]
│       ├── /Advisory/Advisory/Management-Consulting  [BDO.ServiceArea]
│       ├── /Advisory/Advisory/Financial-Modelling-Assurance-Services  [BDO.ServiceArea]
│       │   └── Widgets: BDO.Widget.InsightCarousel
│       ├── /Advisory/Advisory/BDO-Digital  [BDO.ServiceArea]
│       │   └── Widgets: BDO.Widget.FlexibleContent, BDO.Widget.RelatedContacts
│       │   └── /Advisory/Advisory/BDO-Digital/BDO-Digital-Service  [BDO.Service]
│       │       └── Widgets: BDO.Widget.RelatedContentCarousel
│       │       └── /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service  [BDO.SubService]
│       │           └── Widgets: BDO.Widget.TabAccordion, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.FlexibleContent
│       └── /Advisory/Advisory/Actuarial-Services  [BDO.ServiceArea]
│           └── Widgets: BDO.Widget.FlexibleContent, BDO.Widget.RichText, BDO.Widget.Button, BDO.Widget.FlexibleBanner, BDO.Widget.TabAccordion
├── /Industries  [BDO.SectionIndustries]
│   └── /Industries/Financial-Services  [BDO.IndustryCategory]
│       └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.RichText, BDO.Widget.FlexibleContent, BDO.Widget.TrendingTopicsCarousel
│       ├── /Industries/Financial-Services/Tax-Benefit  [BDO.Industry]
│       │   └── Widgets: BDO.Widget.EventsWebinarsSlider
│       │   └── /Industries/Financial-Services/Tax-Benefit/Tax-Benefit-Service  [BDO.IndustryService]
│       └── /Industries/Financial-Services/Asset-management  [BDO.Industry]
│           └── Widgets: BDO.Widget.RelatedContentCarousel
│           └── /Industries/Financial-Services/Asset-management/Asset-management-service  [BDO.IndustryService]
├── /Specialties  [BDO.SectionSpecialties]
│   ├── /Specialties/Secondary-Specialties-category  [BDO.SpecialtiesCategory]
│   └── /Specialties/Specialities-category  [BDO.SpecialtiesCategory]
│       └── /Specialties/Specialities-category/Specialities-area  [BDO.SpecialtiesArea]
├── /Deals  [BDO.SectionDeals]
│   ├── /Deals/Merger-deal-of-2025-SinTech-and-T-T  [BDO.Deal]
│   ├── /Deals/Lape-Deals  [BDO.DealFolder]
│   │   └── /Deals/Lape-Deals/Lape-Demo-Deal  [BDO.Deal]
│   ├── /Deals/Advice-Allegion-in-the-acquisition-of-Dorcas  [BDO.Deal]
│   ├── /Deals/DealU  [BDO.Deal]
│   └── /Deals/Tax-Deal  [BDO.Deal]
├── /News  [BDO.SectionNews]
│   └── /News/2024  [BDO.NewsGroup]
│       ├── /News/2024/September-2023-IASB-Update-available  [BDO.NewsArticle]
│       ├── /News/2024/Why-businesses-should-be-carrying-out-a-data-stock  [BDO.NewsArticle]
│       │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.ImageWithText
│       ├── /News/2024/Investors-flock-to-uranium-as-nuclear-debate-heats  [BDO.NewsArticle]
│       │   └── Widgets: BDO.Widget.SocialMediaButtons
│       └── /News/2024/Help-Sub-Saharan-Africa-Thrive  [BDO.NewsArticle]
├── /Events  [BDO.SectionEvents]
│   ├── /Events/Event-for-demo  [BDO.Event]
│   ├── /Events/Harnessing-the-power-of-AI-and-Microsoft-Copilot-S  [BDO.Event]
│   ├── /Events/Corporate-Tax-Webinar  [BDO.Webinar]
│   ├── /Events/Corporate-Finance-Webinar-Offers-Negotiations-and  [BDO.Event]
│   │   └── Widgets: BDO.Widget.Hero
│   ├── /Events/Rethinking-your-data-protection-with-Microsoft-Pur  [BDO.Event]
│   │   └── Widgets: BDO.Widget.Hero
│   │   ├── /Events/Rethinking-your-data-protection-with-Microsoft-Pur/Dr-Luigi-James  [BDO.Presenter]
│   │   ├── /Events/Rethinking-your-data-protection-with-Microsoft-Pur/Lance-Martin  [BDO.Presenter]
│   │   ├── /Events/Rethinking-your-data-protection-with-Microsoft-Pur/Dorothee-Steiner  [BDO.Presenter]
│   │   ├── /Events/Rethinking-your-data-protection-with-Microsoft-Pur/Christian-Trost-(Moderator)  [BDO.Presenter]
│   │   ├── /Events/Rethinking-your-data-protection-with-Microsoft-Pur/Andreas-Jurgens-(Moderator)  [BDO.Presenter]
│   │   └── /Events/Rethinking-your-data-protection-with-Microsoft-Pur/Register  [BDO.EventRegistrationForm]
│   └── /Events/IBOR-Transition-–-BDO-global-insights-series-Legal  [BDO.Event]
│       └── Widgets: BDO.Widget.Hero
│       └── /Events/IBOR-Transition-–-BDO-global-insights-series-Legal/Register  [BDO.EventRegistrationForm]
├── /Blogs  [BDO.SectionBlogs]
│   └── /Blogs/Fraud-risk-management  [BDO.Blog]
│       ├── /Blogs/Fraud-risk-management/Cyber-fraud  [BDO.BlogPostGroup]
│       │   └── /Blogs/Fraud-risk-management/Cyber-fraud/Uncovering-the-Hidden-Threat-Cyber-Fraud-Risk-Mana  [BDO.BlogPost]
│       │       └── Widgets: BDO.Widget.EditorsPick
│       └── /Blogs/Fraud-risk-management/Fraud-risk-management  [BDO.BlogPostGroup]
│           └── /Blogs/Fraud-risk-management/Fraud-risk-management/Risk-Management-and-Fraud-Management  [BDO.BlogPost]
├── /Careers  [BDO.SectionCareers]
│   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.KeyContacts, BDO.Widget.FlexibleBanner
│   ├── /Careers/Junior-Specialists  [BDO.CareerCategory]
│   └── /Careers/Job-opportunities  [BDO.Careers]
│       ├── /Careers/Job-opportunities/Free-Compliance-Officer-Position  [BDO.Career]
│       ├── /Careers/Job-opportunities/Looking-for-Another-Chartered-Accountant  [BDO.Career]
│       ├── /Careers/Job-opportunities/Looking-for-a-Chartered-Accountant  [BDO.Career]
│       ├── /Careers/Job-opportunities/Solution-Architect  [BDO.Career]
│       └── /Careers/Job-opportunities/Junior-IT-Specialist  [BDO.Career]
├── /External-People  [BDO.SectionExternalPeople]
│   ├── /External-People/Internal-Contributors  [BDO.InternalPeopleFolder]
│   │   └── /External-People/Internal-Contributors/Internal-Contributor  [BDO.InternalPerson]
│   ├── /External-People/External-Contributors  [BDO.ExternalPeopleFolder]
│   │   └── /External-People/External-Contributors/External-Contributors  [BDO.ExternalPerson]
│   ├── /External-People/External-person-2  [BDO.ExternalPerson]
│   ├── /External-People/Heinz-Gerd-Hunfeld  [BDO.ExternalPerson]
│   ├── /External-People/Madilyn-Santillan  [BDO.ExternalPerson]
│   └── /External-People/Example-Group  [BDO.ExternalPeopleFolder]
│       └── /External-People/Example-Group/Dr-Steve-Smith  [BDO.ExternalPerson]
├── /People  [BDO.SectionPeoplePage]
│   ├── /People/Matas-Vaitkus  [BDO.Person]
│   ├── /People/Tom-Thomas  [BDO.Person]
│   ├── /People/HR-Manager-Learning-Development  [BDO.Person]
│   ├── /People/Senior-HR-Manager  [BDO.Person]
│   ├── /People/Leader  [BDO.Person]
│   ├── /People/Tadas-Lape  [BDO.Person]
│   ├── /People/Cassie-Welch  [BDO.Person]
│   ├── /People/Andy-Dillon  [BDO.Person]
│   │   └── Widgets: Kentico.FormWidget
│   └── /People/John-Doe  [BDO.Person]
│       └── Widgets: Kentico.FormWidget
├── /Microsites  [BDO.SectionMicrosites]
│   ├── /Microsites/Some-kind-of-a-campaign  [BDO.MicrositeMasterPage]
│   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.EventsWebinarsSlider, BDO.Widget.InsightCarousel, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContacts
│   │   └── /Microsites/Some-kind-of-a-campaign/Example-campaign-page  [BDO.MicrositePage]
│   │       └── Widgets: BDO.Widget.EventsWebinarsSlider, BDO.Widget.InsightCarousel, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContacts
│   └── /Microsites/New-Master-page  [BDO.MicrositeMasterPage]
│       └── Widgets: BDO.Widget.FlexibleContent, BDO.Widget.EventsWebinarsSlider
├── /Legal  [BDO.SectionLegal]
│   ├── /Legal/Cookies  [BDO.LegalPage]
│   └── /Legal/Privacy  [BDO.LegalPage]
│       └── Widgets: BDO.Widget.RichText
├── /Locations  [BDO.Locations]
│   ├── /Locations/Location-city-(1)  [BDO.LocationCity]
│   │   └── Widgets: BDO.Widget.RelatedContacts, BDO.Widget.ImageWithText
│   │   ├── /Locations/Location-city-(1)/Office-(1)  [BDO.LocationOffice]
│   │   └── /Locations/Location-city-(1)/Office  [BDO.LocationOffice]
│   └── /Locations/Location-city  [BDO.LocationCity]
│       └── Widgets: BDO.Widget.RelatedContacts
│       └── /Locations/Location-city/Office  [BDO.LocationOffice]
├── /Status-Code-Pages  [CMS.Folder]
│   ├── /Status-Code-Pages/404-Page-Not-Found  [BDO.StatusCode]
│   └── /Status-Code-Pages/500-Internal-Server-Error  [BDO.StatusCode]
├── /Navigation  [BDO.Navigation]
│   ├── /Navigation/Industries  [BDO.NavigationFirstLevelItem]
│   │   ├── /Navigation/Industries/Featured-Industry  [BDO.NavigationFeaturedItem]
│   │   └── /Navigation/Industries/Financial-services  [BDO.NavigationSecondLevelItem]
│   ├── /Navigation/Services  [BDO.NavigationFirstLevelItem]
│   │   ├── /Navigation/Services/BDO-Digital  [BDO.NavigationSecondLevelItem]
│   │   │   └── /Navigation/Services/BDO-Digital/BDO-Digital-Service  [BDO.NavigationThirdLevelItem]
│   │   └── /Navigation/Services/Tax  [BDO.NavigationSecondLevelItem]
│   │       ├── /Navigation/Services/Tax/Corporate-international-tax  [BDO.NavigationThirdLevelItem]
│   │       └── /Navigation/Services/Tax/Corporate-and-business-tax  [BDO.NavigationThirdLevelItem]
│   └── /Navigation/Insights  [BDO.NavigationFirstLevelItem]
│       ├── /Navigation/Insights/How-New-EU-Tax-and-Transfer  [BDO.NavigationFeaturedItem]
│       └── /Navigation/Insights/Automotive-Sector-Update-Q3-2023  [BDO.NavigationSecondLevelItem]
├── /Homepage-2  [BDO.HomePage]
│   └── Widgets: BDO.Widget.InsightCarousel
│   └── /Homepage-2/Hero-slide-1  [BDO.HomeHeroSlide]
└── /Accessibility  [BDO.SectionAbout]
    └── /Accessibility/About  [BDO.AboutPage]
```

> **Cultures:** en-GB, he-IL, lt-LT — tree structure is identical across cultures.

- **Total pages:** 174
- **Page types in use:** 79
- **Linked pages:** 0
- **Cultures:** en-GB, he-IL, lt-LT

### E2E & Performance

```text
/  [CMS.Root]
├── /Subscribe  [BDO.Subscribe]
├── /Sitemap  [BDO.Sitemap]
├── /Privacy-policy  [BDO.SectionLegal]
│   └── /Privacy-policy/Privacy-policy  [BDO.LegalPage]
├── /Locations  [BDO.Locations]
├── /Section-Careers  [BDO.SectionCareers]
├── /News  [BDO.SectionNews]
├── /Section-Widget-Content  [BDO.SectionWidgetContent]
├── /Search  [BDO.Search]
├── /Thank-you  [BDO.ThankYouConversionPages]
│   └── /Thank-you/Thank-you  [BDO.ThankYouConversionPage]
├── /Contact-page  [BDO.Contact]
├── /About-Us  [BDO.SectionAbout]
│   └── /About-Us/About-us  [BDO.AboutPage]
├── /Section-Services  [BDO.SectionServices]
│   └── /Section-Services/Advisory  [BDO.BusinessLine]
│       └── /Section-Services/Advisory/Audit-and-Advisory  [BDO.ServiceArea]
├── /Navigation  [BDO.Navigation]
│   ├── /Navigation/About-Us  [BDO.NavigationFirstLevelItem]
│   │   └── /Navigation/About-Us/About-us  [BDO.NavigationSecondLevelItem]
│   ├── /Navigation/Services  [BDO.NavigationFirstLevelItem]
│   │   └── /Navigation/Services/Advisory  [BDO.NavigationSecondLevelItem]
│   │       └── /Navigation/Services/Advisory/Audit  [BDO.NavigationThirdLevelItem]
│   └── /Navigation/Insights  [BDO.NavigationFirstLevelItem]
│       ├── /Navigation/Insights/Featured  [BDO.NavigationFeaturedItem]
│       └── /Navigation/Insights/E2E-Insight  [BDO.NavigationSecondLevelItem]
│           └── /Navigation/Insights/E2E-Insight/E2E-Insight  [BDO.NavigationThirdLevelItem]
├── /Our-People  [BDO.SectionPeoplePage]
│   └── /Our-People/Mr  [BDO.Person]
├── /Microsites  [BDO.SectionMicrosites]
│   └── /Microsites/E2E-Microsite  [BDO.MicrositeMasterPage]
│       └── Widgets: BDO.Widget.ImageWithText
│       └── /Microsites/E2E-Microsite/694818_E2E_Microsite-Test  [BDO.MicrositePage]
│           └── Widgets: BDO.Widget.ImageWithText
├── /Section-Insights  [BDO.SectionInsightsPage]
│   ├── /Section-Insights/E2E-Automated-Insight-Category  [BDO.InsightCategory]
│   │   └── /Section-Insights/E2E-Automated-Insight-Category/694863-E2E_Insight  [BDO.Insight]
│   │       └── Widgets: BDO.Widget.Button
│   └── /Section-Insights/Audit  [BDO.InsightCategory]
│       └── /Section-Insights/Audit/E2E-Insight  [BDO.Insight]
└── /Home-page  [BDO.HomePage]
    ├── /Home-page/Featured-topics  [BDO.TrendingTopics]
    │   └── /Home-page/Featured-topics/Trending-topic  [BDO.TrendingTopic]
    ├── /Home-page/Curabitur-augue-quam,-feugiat-vel-dolor-quis,-maxi  [BDO.HomeHeroSlide]
    └── /Home-page/Lorem-ipsum-dolor-sit-amet,-consectetur-adipiscing  [BDO.HomeHeroSlide]
```

> **Cultures:** en-GB, he-IL, lt-LT — tree structure is identical across cultures.

- **Total pages:** 43
- **Page types in use:** 35
- **Linked pages:** 0
- **Cultures:** en-GB, he-IL, lt-LT

### GWT BDO India team

```text
/  [CMS.Root]
├── /People  [BDO.SectionPeoplePage]
│   └── /People/Tapasya  [BDO.Person]
├── /Deals  [BDO.SectionDeals]
│   └── Widgets: BDO.Widget.Hero
│   └── /Deals/Deal-MV  [BDO.Deal]
│       └── Widgets: BDO.Widget.KeyContacts
├── /Insights  [BDO.SectionInsightsPage]
│   ├── /Insights/Hotfix-195  [BDO.Insight]
│   ├── /Insights/EV-GWT-article-4  [BDO.Insight]
│   │   └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.RichText
│   ├── /Insights/DEV-Site-for-BCR-2-(1)  [BDO.Insight]
│   ├── /Insights/DEV-Site-for-BCR-2  [BDO.Insight]
│   ├── /Insights/After-change-test-(2)  [BDO.Insight]
│   ├── /Insights/After-change-test-(1)  [BDO.Insight]
│   ├── /Insights/Dev-insight  [BDO.Insight]
│   ├── /Insights/After-change-test  [BDO.Insight]
│   └── /Insights/Category  [BDO.InsightCategory]
│       └── /Insights/Category/test-group  [BDO.InsightGroup]
├── /Careers  [BDO.SectionCareers]
│   ├── /Careers/Junior-QA  [BDO.CareerCategory]
│   └── /Careers/Job-opportunities  [BDO.Careers]
│       └── /Careers/Job-opportunities/QA-Tester  [BDO.Career]
└── /Home  [BDO.HomePage]
    └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.TiledLinkSection, BDO.Widget.QuoteCard
    ├── /Home/Test  [BDO.HomeHeroSlide]
    ├── /Home/Home-Hero-Slide-1  [BDO.HomeHeroSlide]
    └── /Home/Featured-topics  [BDO.TrendingTopics]
        └── /Home/Featured-topics/t1  [BDO.TrendingTopic]
```

> **Cultures:** en-GB — tree structure is identical across cultures.

- **Total pages:** 25
- **Page types in use:** 17
- **Linked pages:** 0
- **Cultures:** en-GB

### GWT Export

```text
/  [CMS.Root]
├── /Subscribe  [BDO.Subscribe]
├── /Section-Widget-Content  [BDO.SectionWidgetContent]
├── /Services  [BDO.SectionServices]
│   └── /Services/Business-line  [BDO.BusinessLine]
│       └── /Services/Business-line/Service-Area  [BDO.ServiceArea]
│           └── /Services/Business-line/Service-Area/Service  [BDO.Service]
│               └── /Services/Business-line/Service-Area/Service/Sub-service  [BDO.SubService]
├── /Section-indsutries  [BDO.SectionIndustries]
│   └── /Section-indsutries/Финансовыи-сектор  [BDO.IndustryCategory]
│       └── /Section-indsutries/Финансовыи-сектор/Industry  [BDO.Industry]
│           └── /Section-indsutries/Финансовыи-сектор/Industry/Industry-service  [BDO.IndustryService]
├── /Section-insights  [BDO.SectionInsightsPage]
│   └── /Section-insights/Insight  [BDO.Insight]
├── /Section-Blog  [BDO.SectionBlogs]
│   └── /Section-Blog/Blog-group  [BDO.Blog]
│       ├── /Section-Blog/Blog-group/contributors  [BDO.BlogContributors]
│       │   └── /Section-Blog/Blog-group/contributors/Name-last  [BDO.Person]
│       └── /Section-Blog/Blog-group/Blog-post-group  [BDO.BlogPostGroup]
│           └── /Section-Blog/Blog-group/Blog-post-group/Blog-post  [BDO.BlogPost]
├── /Section-Deals  [BDO.SectionDeals]
│   └── /Section-Deals/Deal-page  [BDO.Deal]
├── /Our-people  [BDO.SectionPeoplePage]
│   ├── /Our-people/Person-Another-Site  [BDO.Person]
│   ├── /Our-people/Person-Attach  [BDO.Person]
│   └── /Our-people/Person-Media  [BDO.Person]
├── /Section-blogs  [BDO.SectionBlogs]
│   └── /Section-blogs/Section-blogs  [BDO.Blog]
│       ├── /Section-blogs/Section-blogs/Blog-post-group  [BDO.BlogPostGroup]
│       │   └── /Section-blogs/Section-blogs/Blog-post-group/Blog-post  [BDO.BlogPost]
│       └── /Section-blogs/Section-blogs/blog-contributor  [BDO.BlogContributors]
│           └── /Section-blogs/Section-blogs/blog-contributor/contributor-person  [BDO.Person]
├── /Section-about  [BDO.SectionAbout]
│   └── /Section-about/about-page  [BDO.AboutPage]
├── /Search  [BDO.Search]
├── /Navigation  [BDO.Navigation]
│   └── /Navigation/Navigation-first-level  [BDO.NavigationFirstLevelItem]
│       ├── /Navigation/Navigation-first-level/navigation-second-level  [BDO.NavigationSecondLevelItem]
│       │   └── /Navigation/Navigation-first-level/navigation-second-level/navigation-third-level  [BDO.NavigationThirdLevelItem]
│       └── /Navigation/Navigation-first-level/navigation-featured-item  [BDO.NavigationFeaturedItem]
├── /locations  [BDO.Locations]
│   └── /locations/location-city  [BDO.LocationCity]
│       └── /locations/location-city/location-office  [BDO.LocationOffice]
├── /Global-locations  [BDO.GlobalLocations]
├── /Contact  [BDO.Contact]
└── /Homepage  [BDO.HomePage]
    ├── /Homepage/Featured-topics  [BDO.TrendingTopics]
    │   └── /Homepage/Featured-topics/trending-topic-1  [BDO.TrendingTopic]
    └── /Homepage/Home-hero-slide-1  [BDO.HomeHeroSlide]
```

> **Cultures:** en-GB, ru-RU — tree structure is identical across cultures.

- **Total pages:** 49
- **Page types in use:** 40
- **Linked pages:** 0
- **Cultures:** en-GB, ru-RU

### GWT TST

```text
├── /  [CMS.Root]
│   ├── /Section-Widget-Content  [BDO.SectionWidgetContent]
│   │   ├── /Section-Widget-Content/In-Focus-folder  [BDO.InFocusFolder]
│   │   │   ├── /Section-Widget-Content/In-Focus-folder/About-pages  [BDO.InFocusPage]
│   │   │   ├── /Section-Widget-Content/In-Focus-folder/Business-productivity  [BDO.InFocusPage]
│   │   │   ├── /Section-Widget-Content/In-Focus-folder/In-Focus  [BDO.InFocusPage]
│   │   │   └── /Section-Widget-Content/In-Focus-folder/In-Focus-Page-1  [BDO.InFocusPage]
│   │   ├── /Section-Widget-Content/In-Focus  [BDO.InFocusFolder]
│   │   │   └── /Section-Widget-Content/In-Focus/In-focus-test  [BDO.InFocusPage]
│   │   ├── /Section-Widget-Content/In-focus-2  [BDO.InFocusFolder]
│   │   │   └── /Section-Widget-Content/In-focus-2/In-focus-page-2  [BDO.InFocusPage]
│   │   └── /Section-Widget-Content/FAQ  [BDO.FaqFolder]
│   │       ├── /Section-Widget-Content/FAQ/2-Why-is-ESG-important-to-our-organization  [BDO.FaqTopic]
│   │       │   ├── /Section-Widget-Content/FAQ/2-Why-is-ESG-important-to-our-organization/How-can-employees-contribute-to-our-sustainability  [BDO.FaqPage]
│   │       │   ├── /Section-Widget-Content/FAQ/2-Why-is-ESG-important-to-our-organization/What-does-ESG-mean  [BDO.FaqPage]
│   │       │   └── /Section-Widget-Content/FAQ/2-Why-is-ESG-important-to-our-organization/Why-is-ESG-important-to-our-organization  [BDO.FaqPage]
│   │       └── /Section-Widget-Content/FAQ/FAQ-topic-1  [BDO.FaqTopic]
│   │           ├── /Section-Widget-Content/FAQ/FAQ-topic-1/FAQ-Page-(1)  [BDO.FaqPage]
│   │           └── /Section-Widget-Content/FAQ/FAQ-topic-1/FAQ-Page  [BDO.FaqPage]
│   ├── /Widget-content  [BDO.SectionAbout]
│   │   ├── /Widget-content/FAQ-pages  [BDO.ThankYouConversionPages]
│   │   │   ├── /Widget-content/FAQ-pages/FAQ-Topic-item-Climate-reporting  [BDO.ThankYouConversionPage]
│   │   │   └── /Widget-content/FAQ-pages/FAQ-Topic-Items  [BDO.ThankYouConversionPage]
│   │   └── /Widget-content/In-Focus-pages-(1)  [BDO.ThankYouConversionPages]
│   │       ├── /Widget-content/In-Focus-pages-(1)/Menu-Topics-Items  [BDO.ThankYouConversionPage]
│   │       ├── /Widget-content/In-Focus-pages-(1)/Menu-Topic-Service-2  [BDO.ThankYouConversionPage]
│   │       └── /Widget-content/In-Focus-pages-(1)/Menu-Topics-Item-Industries  [BDO.ThankYouConversionPage]
│   ├── /RSS-(1)  [BDO.SectionRss]
│   ├── /RSS-(2)  [BDO.SectionRss]
│   │   └── /RSS-(2)/RSS-Feed-Title  [BDO.Rss]
│   ├── /Homepage  [BDO.HomePage]
│   │   └── Widgets: BDO.Widget.InsightCarousel, Kentico.FormWidget, BDO.Widget.TiledLinkSection, BDO.Widget.EventsWebinarsSlider, BDO.Widget.NewsCarousel, BDO.Widget.Button, BDO.Widget.RichText, BDO.Widget.ViewGlobalLocations, BDO.Widget.SocialMediaButtons
│   │   ├── /Homepage/When-Life-Gives-You-Lemons  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/MV-hero-slide  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/CZ  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Lape-Home-Hero-Slide  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/New-Slide  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Testing-Slide-Preview  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Hero-(1)  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/test  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Heading-for-testing-(1)  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Demo-Slide  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/1-New-slide-(1)  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Heading-for-testing  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Hero  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/1-New-slide  [BDO.HomeHeroSlide]
│   │   ├── /Homepage/Hero-2  [BDO.HomeHeroSlide]
│   │   └── /Homepage/Featured-topics  [BDO.TrendingTopics]
│   │       ├── /Homepage/Featured-topics/Lape-Trending-Topic  [BDO.TrendingTopic]
│   │       ├── /Homepage/Featured-topics/New-Trending-topic  [BDO.TrendingTopic]
│   │       ├── /Homepage/Featured-topics/Homepage-Featured  [BDO.TrendingTopic]
│   │       └── /Homepage/Featured-topics/Taxes  [BDO.TrendingTopic]
│   ├── /Lape-Subscribe-Edited  [BDO.Subscribe]
│   │   ├── /Lape-Subscribe-Edited/Lape-Subscription-Confirmation  [BDO.SubscribeConfirm]
│   │   └── /Lape-Subscribe-Edited/Lape-Unsubscription-Confirmation  [BDO.SubscribeRemove]
│   ├── /Error-Pages  [CMS.Folder]
│   │   ├── /Error-Pages/401-Unauthorized  [BDO.StatusCode]
│   │   ├── /Error-Pages/403-Forbidden  [BDO.StatusCode]
│   │   ├── /Error-Pages/404-Not-Found  [BDO.StatusCode]
│   │   └── /Error-Pages/500-Internal-Server-Error  [BDO.StatusCode]
│   ├── /Digital  [BDO.SectionMicrosites]
│   │   └── /Digital/Digital  [BDO.MicrositeMasterPage]
│   │       └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.ImageWithText, BDO.Widget.HTML, BDO.Widget.FlexibleBanner
│   │       ├── /Digital/Digital/Test-Martin  [BDO.MicrositePage]
│   │       │   └── /Digital/Digital/Test-Martin/Digital-Backoffice  [BDO.MicrositePage]
│   │       │       └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.ImageWithText, BDO.Widget.InsightCarousel
│   │       │       └── /Digital/Digital/Test-Martin/Digital-Backoffice/Audit  [BDO.MicrositePage]
│   │       │           └── /Digital/Digital/Test-Martin/Digital-Backoffice/Audit/Insights  [BDO.MicrositePage]
│   │       │               └── Widgets: BDO.Widget.Hero, BDO.Widget.InsightCarousel, BDO.Widget.HTML
│   │       └── /Digital/Digital/Services  [BDO.MicrositePage]
│   │           └── Widgets: BDO.Widget.Hero, BDO.Widget.HTML
│   ├── /Testimonials-(Lape)  [BDO.SectionTestimonials]
│   │   └── /Testimonials-(Lape)/Testimonial  [BDO.TestimonialType]
│   ├── /External-People  [BDO.SectionExternalPeople]
│   │   ├── /External-People/Legacy-Blog-Contributor  [BDO.ExternalPeopleFolder]
│   │   ├── /External-People/Internal-contributor-2  [BDO.InternalPerson]
│   │   ├── /External-People/Internal-People  [BDO.InternalPeopleFolder]
│   │   │   ├── /External-People/Internal-People/internal-contributor-folder  [BDO.InternalPeopleFolder]
│   │   │   └── /External-People/Internal-People/Internal-contributor-1  [BDO.InternalPerson]
│   │   ├── /External-People/Folder  [BDO.ExternalPeopleFolder]
│   │   │   └── /External-People/Folder/New-External-Person  [BDO.ExternalPerson]
│   │   ├── /External-People/Person-1  [BDO.ExternalPerson]
│   │   ├── /External-People/Donald-Duck  [BDO.ExternalPerson]
│   │   └── /External-People/Heinz-Gerd-Hunfeld  [BDO.ExternalPerson]
│   ├── /Insights  [BDO.SectionInsightsPage]
│   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel, BDO.Widget.ViewGlobalLocations
│   │   ├── /Insights/JJ-New-Insight-no-modifications-(1)  [BDO.Insight]
│   │   ├── /Insights/Insight  [BDO.Insight]
│   │   ├── /Insights/Matas-Quote-demo-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.ExternalNavigation, BDO.Widget.Button, BDO.Widget.RelatedContentCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.Faq, BDO.Widget.QuoteCard, BDO.Widget.InsightCarousel, BDO.Widget.RichText
│   │   ├── /Insights/JJ-New-Insight-no-modifications  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.ExternalNavigation, BDO.Widget.RelatedContentCarousel
│   │   ├── /Insights/EV-GWT-Article-10  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Faq, BDO.Widget.RelatedContentCarousel, BDO.Widget.RichText, BDO.Widget.InsightCarousel, BDO.Widget.QuoteCard, BDO.Widget.InFocus, BDO.Widget.KeyContacts, BDO.Widget.HTML, BDO.Widget.SocialMediaButtons
│   │   ├── /Insights/test-one-two  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel
│   │   ├── /Insights/EV-GWT-article-9  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.KeyContacts, BDO.Widget.FlexibleContent, BDO.Widget.Faq, BDO.Widget.InsightCarousel
│   │   ├── /Insights/EV-GWT-Article-8  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.HTML, BDO.Widget.RichText, BDO.Widget.SocialMediaButtons, BDO.Widget.Button, BDO.Widget.ImageWithText, BDO.Widget.FlexibleContent
│   │   ├── /Insights/EV-GWT-article-7  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.ExternalNavigation, BDO.Widget.Button, BDO.Widget.RelatedContentCarousel, BDO.Widget.Faq
│   │   ├── /Insights/MV-insight-category  [BDO.InsightCategory]
│   │   │   ├── /Insights/MV-insight-category/Insight-with-hero  [BDO.Insight]
│   │   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.ImageWithText, BDO.Widget.HTML
│   │   │   └── /Insights/MV-insight-category/Reports-Horizon  [BDO.Insight]
│   │   │       └── Widgets: BDO.Widget.RichText, BDO.Widget.HTML
│   │   ├── /Insights/EV-GWT-article-3  [BDO.InsightCategory]
│   │   ├── /Insights/EV-GWT-article-6  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.QuoteCard, BDO.Widget.EditorsPick
│   │   ├── /Insights/EV-GWT-article-4-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.InsightCarousel, BDO.Widget.KeyContacts, BDO.Widget.SocialMediaButtons
│   │   ├── /Insights/Matas-Quote-demo  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.Button, BDO.Widget.QuoteCard, BDO.Widget.EditorsPick, BDO.Widget.InsightCarousel, BDO.Widget.RichText
│   │   ├── /Insights/EV-GWT-article-4  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, Kentico.FormWidget, BDO.Widget.HTML, BDO.Widget.KeyContacts, BDO.Widget.SocialMediaButtons, BDO.Widget.FlexibleContent, BDO.Widget.EditorsPick, BDO.Widget.EventsWebinarsSlider, BDO.Widget.RelatedContentCarousel, BDO.Widget.InsightCarousel
│   │   ├── /Insights/New-insight-for-CR-testing-(2)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Accordion, BDO.Widget.SocialMediaButtons, BDO.Widget.FlexibleBanner
│   │   ├── /Insights/Test-Ali  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.FlexibleContent, BDO.Widget.RelatedContentCarousel
│   │   ├── /Insights/Test-creation-of-new-Insight-(2)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.QuoteCard, BDO.Widget.FlexibleContent, BDO.Widget.InsightCarousel, BDO.Widget.HTML
│   │   ├── /Insights/EV-API-Test-1  [BDO.Insight]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.FlexibleContent, BDO.Widget.RichText
│   │   ├── /Insights/Test-Ondemand-event  [BDO.Insight]
│   │   ├── /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.SocialMediaButtons, BDO.Widget.RelatedContentCarousel, BDO.Widget.ImageWithText, BDO.Widget.HTML
│   │   ├── /Insights/מיסים  [BDO.InsightCategory]
│   │   │   ├── /Insights/מיסים/Julegave-fra-arbeidsgiver-skattefritt-eller-skatte  [BDO.Insight]
│   │   │   │   └── Linked -> /Insights/IT-Compliance/Julegave-fra-arbeidsgiver-skattefritt-eller-skatte [BDO.Insight]
│   │   │   └── /Insights/מיסים/מבזקי-מס  [BDO.InsightGroup]
│   │   │       └── /Insights/מיסים/מבזקי-מס/2022-היערכות-לקראת-סוף-שנת-המס  [BDO.Insight]
│   │   ├── /Insights/Julegave-fra-arbeidsgiver-skattefritt-eller  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.KeyTakeaways, BDO.Widget.ImageWithText
│   │   ├── /Insights/Characters-test-oe-ss-ou  [BDO.Insight]
│   │   ├── /Insights/Insight-Page-Title-H1  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.KeyContacts
│   │   ├── /Insights/IT-Compliance  [BDO.InsightCategory]
│   │   │   ├── /Insights/IT-Compliance/Julegave-fra-arbeidsgiver-skattefritt-eller-skatte  [BDO.Insight]
│   │   │   └── /Insights/IT-Compliance/BDO-Leitfaden-zu-europaischen-Technologievorschrif  [BDO.Insight]
│   │   ├── /Insights/E2E_Insight_Category_Automated  [BDO.InsightCategory]
│   │   │   ├── /Insights/E2E_Insight_Category_Automated/JV-Insight  [BDO.Insight]
│   │   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.InsightCarousel
│   │   │   └── /Insights/E2E_Insight_Category_Automated/694863_E2E_Insight  [BDO.Insight]
│   │   │       └── Widgets: BDO.Widget.Button
│   │   ├── /Insights/Insight-with-default-container-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RelatedContentCarousel, BDO.Widget.ImageWithText, BDO.Widget.RichText
│   │   ├── /Insights/Insight-with-default-container  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.SocialMediaButtons, BDO.Widget.QuoteCard
│   │   ├── /Insights/My-test-22-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.ImageWithText, BDO.Widget.SocialMediaButtons
│   │   ├── /Insights/Insighast-(1)2  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.NewsCarousel, BDO.Widget.RichText, BDO.Widget.Button, BDO.Widget.Accordion
│   │   ├── /Insights/2023-Automotive-Year-End-Tax-Bulletin-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, Kentico.FormWidget
│   │   ├── /Insights/Hikaruuuu-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.NewsCarousel
│   │   ├── /Insights/Insight-to-test-copied-insights  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.NewsCarousel, BDO.Widget.Accordion, BDO.Widget.EventsWebinarsSlider
│   │   ├── /Insights/My-test-22  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   ├── /Insights/Test-creation-of-new-Insight-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   ├── /Insights/DEV-Site-for-BCR-2-(3)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts, BDO.Widget.EditorsPick, BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel
│   │   ├── /Insights/After-hiding  [BDO.Insight]
│   │   ├── /Insights/After-change-test-(1)-Changed  [BDO.Insight]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Insights/Insight-from-future1  [BDO.Insight]
│   │   ├── /Insights/Lukas-Testing-(3)  [BDO.Insight]
│   │   ├── /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(2)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.InsightCarousel, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.RichText
│   │   ├── /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.InsightCarousel, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.RichText
│   │   ├── /Insights/Testing-new-1  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.InsightCarousel, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.RichText, BDO.Widget.QuoteCard, BDO.Widget.NewsCarousel
│   │   ├── /Insights/New-insight-for-CR-testing-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Accordion, BDO.Widget.FlexibleBanner
│   │   ├── /Insights/After-change-test  [BDO.Insight]
│   │   ├── /Insights/DEV-Site-for-BCR-2-(2)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel
│   │   ├── /Insights/DEV-Site-for-BCR-2-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel
│   │   ├── /Insights/Insight-for-Copy-from-Demo-(1)  [BDO.Insight]
│   │   ├── /Insights/DEV-Site-for-BCR-2  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel
│   │   ├── /Insights/Lukas-testing-(2)  [BDO.InsightCategory]
│   │   │   └── Widgets: BDO.Widget.Button
│   │   │   ├── /Insights/Lukas-testing-(2)/test-group  [BDO.InsightGroup]
│   │   │   └── /Insights/Lukas-testing-(2)/Lukas-Testing  [BDO.InsightGroup]
│   │   │       └── Widgets: BDO.Widget.Button
│   │   ├── /Insights/DEV-Site-for-BCR  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel
│   │   ├── /Insights/Insight-for-Copy-from-Demo  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.NewsCarousel
│   │   ├── /Insights/New-insight-for-CR-testing  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Accordion, BDO.Widget.FlexibleBanner, Kentico.FormWidget
│   │   ├── /Insights/Very-new-insight-NV  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Button
│   │   ├── /Insights/Insightttttttasd-(1)  [BDO.Insight]
│   │   ├── /Insights/Dev-insight-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.FlexibleBanner
│   │   ├── /Insights/Lukas-Testing-(1)  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   ├── /Insights/Hikaruuuu  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.KeyContacts, BDO.Widget.SocialMediaButtons
│   │   ├── /Insights/Koub-af-unoterede-aktier-for-pensionsmidler  [BDO.Insight]
│   │   ├── /Insights/Dev-insight  [BDO.Insight]
│   │   ├── /Insights/prasau-veeeeeeik  [BDO.Insight]
│   │   ├── /Insights/Insightttttttasd  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   ├── /Insights/Test-Arial-Alternatives-(1)  [BDO.Insight]
│   │   ├── /Insights/Test-Arial-Alternatives  [BDO.Insight]
│   │   ├── /Insights/MP-Reachmee  [BDO.Insight]
│   │   ├── /Insights/Insight-to-publish-in-the-future  [BDO.Insight]
│   │   ├── /Insights/Lukas-T  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Accordion, BDO.Widget.InsightCarousel, BDO.Widget.FlexibleContent, BDO.Widget.ImageWithText
│   │   ├── /Insights/!Insight-category  [BDO.InsightCategory]
│   │   │   ├── /Insights/!Insight-category/Koub-af-unoterede-aktier-for-pensionsmidler  [BDO.Insight]
│   │   │   └── /Insights/!Insight-category/Edit-me  [BDO.Insight]
│   │   │       └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.RichText, Kentico.FormWidget, BDO.Widget.Accordion, BDO.Widget.FlexibleBanner, BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleContent
│   │   ├── /Insights/Germany-Federal-Fiscal-Court-rules-on-financial-in  [BDO.Insight]
│   │   ├── /Insights/Gated-downloads  [BDO.ThankYouConversionPages]
│   │   │   └── /Insights/Gated-downloads/Download-the-report  [BDO.ThankYouConversionPage]
│   │   │       └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText
│   │   ├── /Insights/Test-of-gated-downloads-form  [BDO.ThankYouConversionPage]
│   │   ├── /Insights/Insight-Category-EV  [BDO.InsightCategory]
│   │   │   └── /Insights/Insight-Category-EV/EV-Insight  [BDO.Insight]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Insights/September-Article  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   ├── /Insights/Bullet-points-alignment  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.HTML, BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider
│   │   ├── /Insights/Social-Test  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.EventsWebinarsSlider, BDO.Widget.InsightCarousel
│   │   ├── /Insights/MP-Insight  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.InsightCarousel, BDO.Widget.HTML, BDO.Widget.RichText
│   │   ├── /Insights/CTA-test  [BDO.Insight]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.RichText
│   │   ├── /Insights/KR-Insight-@-BDO  [BDO.InsightCategory]
│   │   │   └── /Insights/KR-Insight-@-BDO/KR-Insight-Group  [BDO.InsightGroup]
│   │   │       └── /Insights/KR-Insight-@-BDO/KR-Insight-Group/KR-Insight22  [BDO.Insight]
│   │   │           └── Widgets: BDO.Widget.RichText
│   │   ├── /Insights/Category-EV  [BDO.InsightCategory]
│   │   ├── /Insights/RK-Category  [BDO.InsightCategory]
│   │   │   ├── /Insights/RK-Category/Sustainability-at-BDO  [BDO.Insight]
│   │   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, Kentico.FormWidget, BDO.Widget.QuoteCard, BDO.Widget.Accordion, BDO.Widget.RelatedContacts
│   │   │   ├── /Insights/RK-Category/Date-format  [BDO.Insight]
│   │   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Insights/RK-Category/Table-test  [BDO.Insight]
│   │   │   ├── /Insights/RK-Category/Insight-Page-test-to-KR  [BDO.Insight]
│   │   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.InsightCarousel, BDO.Widget.KeyContacts
│   │   │   └── /Insights/RK-Category/RK-Category  [BDO.Insight]
│   │   │       └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.InsightCarousel, BDO.Widget.RichText, BDO.Widget.HTML
│   │   ├── /Insights/Test  [BDO.InsightCategory]
│   │   │   └── Widgets: BDO.Widget.Button, BDO.Widget.RichText
│   │   ├── /Insights/Healthcare  [BDO.InsightCategory]
│   │   ├── /Insights/Manufacturing  [BDO.InsightCategory]
│   │   ├── /Insights/Insight-1  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.KeyContacts, BDO.Widget.HTML, BDO.Widget.Accordion
│   │   ├── /Insights/2023-Automotive-Year-End-Tax-Bulletin  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.KeyContacts, Kentico.FormWidget, BDO.Widget.InsightCarousel
│   │   ├── /Insights/Insight-2  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.ExternalNavigation, BDO.Widget.Button, BDO.Widget.InsightCarousel, BDO.Widget.FlexibleBanner, BDO.Widget.Accordion, Kentico.FormWidget, BDO.Widget.HTML, BDO.Widget.RichText
│   │   ├── /Insights/Insight-Category  [BDO.InsightCategory]
│   │   ├── /Insights/Insight-w-o-tagging  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.KeyContacts, BDO.Widget.Button
│   │   ├── /Insights/Insight_Form-testing  [BDO.Insight]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.InsightCarousel, BDO.Widget.RichText
│   │   ├── /Insights/Lape-Insight  [BDO.Insight]
│   │   │   └── Widgets: BDO.Widget.KeyTakeaways, BDO.Widget.InFocus
│   │   └── /Insights/JJ-Insight-category  [BDO.InsightCategory]
│   │       ├── /Insights/JJ-Insight-category/No-Sidebar-Insight-Page-2  [BDO.Insight]
│   │       │   └── Widgets: BDO.Widget.Hero, BDO.Widget.ImageWithText
│   │       ├── /Insights/JJ-Insight-category/Reports-Horizon  [BDO.Insight]
│   │       │   └── Widgets: BDO.Widget.RichText, BDO.Widget.HTML
│   │       ├── /Insights/JJ-Insight-category/Insight-without-structured-content  [BDO.Insight]
│   │       │   └── Widgets: BDO.Widget.RichText
│   │       ├── /Insights/JJ-Insight-category/JJ-Article  [BDO.Insight]
│   │       │   └── Widgets: BDO.Widget.RichText, BDO.Widget.SocialMediaButtons, BDO.Widget.KeyContacts, BDO.Widget.HTML
│   │       ├── /Insights/JJ-Insight-category/No-sidebar-Insight-(1)  [BDO.Insight]
│   │       │   └── Widgets: BDO.Widget.RichText, BDO.Widget.KeyContacts, Kentico.FormWidget, BDO.Widget.EditorsPick
│   │       └── /Insights/JJ-Insight-category/JJ-Insight-group  [BDO.InsightGroup]
│   │           ├── /Insights/JJ-Insight-category/JJ-Insight-group/JJ-New-Insight-no-modifications  [BDO.Insight]
│   │           ├── /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-to-test-embeded-content  [BDO.Insight]
│   │           │   └── Widgets: BDO.Widget.HTML, BDO.Widget.RichText
│   │           ├── /Insights/JJ-Insight-category/JJ-Insight-group/Insight-to-test-RSS  [BDO.Insight]
│   │           ├── /Insights/JJ-Insight-category/JJ-Insight-group/No-sidebar-Insight  [BDO.Insight]
│   │           ├── /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias  [BDO.Insight]
│   │           │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.EventsWebinarsSlider, BDO.Widget.NewsCarousel, BDO.Widget.InsightCarousel, BDO.Widget.Accordion, BDO.Widget.EditorsPick, BDO.Widget.ImageWithText, BDO.Widget.SocialMediaButtons, BDO.Widget.HTML
│   │           └── /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging  [BDO.Insight]
│   │               └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.QuoteCard, BDO.Widget.InsightCarousel, Kentico.FormWidget, BDO.Widget.ImageWithText, BDO.Widget.RichText, BDO.Widget.EventsWebinarsSlider, BDO.Widget.Button, BDO.Widget.Accordion, BDO.Widget.NewsCarousel, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts, BDO.Widget.EditorsPick
│   ├── /საქართველოში  [BDO.SectionServices]
│   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel, Kentico.FormWidget, BDO.Widget.KeyContacts
│   │   ├── /საქართველოში/MV-Business-Line  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TabAccordion
│   │   │   └── /საქართველოში/MV-Business-Line/MV-Service-area  [BDO.ServiceArea]
│   │   │       └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.EditorsPick, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.Faq
│   │   ├── /საქართველოში/Demo-Business-line  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.NewsCarousel, BDO.Widget.TabAccordion, BDO.Widget.TiledLinkSection, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.ImageWithText, BDO.Widget.RichText, BDO.Widget.EditorsPick, BDO.Widget.RelatedContacts
│   │   │   └── /საქართველოში/Demo-Business-line/Demo-Service-Area  [BDO.ServiceArea]
│   │   │       └── Widgets: BDO.Widget.NewsCarousel, BDO.Widget.QuoteCard, BDO.Widget.EditorsPick, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.RichText, BDO.Widget.HTML, BDO.Widget.TiledLinkSection
│   │   │       └── /საქართველოში/Demo-Business-line/Demo-Service-Area/Demo-Service  [BDO.Service]
│   │   │           └── Widgets: BDO.Widget.SocialMediaButtons, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContentCarousel, BDO.Widget.TrendingTopicsCarousel
│   │   │           └── /საქართველოში/Demo-Business-line/Demo-Service-Area/Demo-Service/Demo-Sub-Service  [BDO.SubService]
│   │   ├── /საქართველოში/BDO-APT-Help-Business-Line  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.RelatedContentCarousel, Kentico.FormWidget
│   │   ├── /საქართველოში/Secured-Business-Line  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TiledLinkSection
│   │   ├── /საქართველოში/Міжнародна-аудиторська-компанія-BDO-BDO  [BDO.BusinessLine]
│   │   ├── /საქართველოში/Consulting-Unternehmensberatung  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel, BDO.Widget.EditorsPick, BDO.Widget.KeyContacts, BDO.Widget.InsightCarousel, BDO.Widget.RichText, BDO.Widget.ImageWithText, BDO.Widget.Accordion, BDO.Widget.HTML
│   │   │   ├── /საქართველოში/Consulting-Unternehmensberatung/Service-Area-EV  [BDO.ServiceArea]
│   │   │   ├── /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.RichText, BDO.Widget.EditorsPick
│   │   │   └── /საქართველოში/Consulting-Unternehmensberatung/Service-Area-2  [BDO.ServiceArea]
│   │   │       └── Widgets: BDO.Widget.TrendingTopicsCarousel, BDO.Widget.InsightCarousel
│   │   ├── /საქართველოში/Test  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel, BDO.Widget.FlexibleContent, Kentico.FormWidget, BDO.Widget.KeyContacts, BDO.Widget.ViewGlobalLocations
│   │   ├── /საქართველოში/Hellou  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.KeyContacts, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.Button, BDO.Widget.FlexibleContent, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.ViewGlobalLocations, BDO.Widget.EventsWebinarsSlider, BDO.Widget.TiledLinkSection, BDO.Widget.NewsCarousel, Kentico.FormWidget
│   │   ├── /საქართველოში/URL-Rædiræction-Tæst  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel
│   │   ├── /საქართველოში/BDO-Digital  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.ViewGlobalLocations, BDO.Widget.NewsCarousel
│   │   │   └── /საქართველოში/BDO-Digital/Financial-Services  [BDO.ServiceArea]
│   │   │       └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.Button, BDO.Widget.TabAccordion, Kentico.FormWidget, BDO.Widget.KeyContacts, BDO.Widget.InsightCarousel, BDO.Widget.RelatedContentCarousel, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.TiledLinkSection, BDO.Widget.NewsCarousel, BDO.Widget.EventsWebinarsSlider
│   │   │       └── /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory  [BDO.Service]
│   │   │           └── Widgets: BDO.Widget.RelatedContentCarousel, BDO.Widget.EditorsPick, BDO.Widget.FlexibleContent, BDO.Widget.NewsCarousel, BDO.Widget.EventsWebinarsSlider
│   │   ├── /საქართველოში/Sustainability-and-ESG  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.RelatedContacts
│   │   │   ├── /საქართველოში/Sustainability-and-ESG/Climate-Mitigation  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.InsightCarousel
│   │   │   ├── /საქართველოში/Sustainability-and-ESG/ESG-Assurance  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.TiledLinkSection
│   │   │   └── /საქართველოში/Sustainability-and-ESG/ESG-Strategy-Program-Development  [BDO.ServiceArea]
│   │   ├── /საქართველოში/Audit-Assurance  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel
│   │   │   ├── /საქართველოში/Audit-Assurance/IT-Risk-Advisory  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.TabAccordion
│   │   │   ├── /საქართველოში/Audit-Assurance/Risk-Advisory-Services  [BDO.ServiceArea]
│   │   │   └── /საქართველოში/Audit-Assurance/Audit-Services  [BDO.ServiceArea]
│   │   │       └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.HTML
│   │   │       └── /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality  [BDO.Service]
│   │   │           └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.FlexibleBanner, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.TabAccordion, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts
│   │   ├── /საქართველოში/Advisory  [BDO.BusinessLine]
│   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel, BDO.Widget.KeyContacts, BDO.Widget.EventsWebinarsSlider, BDO.Widget.InsightCarousel
│   │   │   ├── /საქართველოში/Advisory/Page-with-special-characters-in-URLae  [BDO.ServiceArea]
│   │   │   ├── /საქართველოში/Advisory/ESG-Suistanability-reporting  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.Faq, BDO.Widget.InFocus, BDO.Widget.EditorsPick
│   │   │   ├── /საქართველოში/Advisory/Risk-Advisory-Services  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel
│   │   │   ├── /საქართველოში/Advisory/Global-forensics  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel, BDO.Widget.InsightCarousel, BDO.Widget.TabAccordion
│   │   │   │   ├── /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio  [BDO.Service]
│   │   │   │   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.TrendingTopicsCarousel
│   │   │   │   │   ├── /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/test-sub  [BDO.SubService]
│   │   │   │   │   └── /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/Sub-Service  [BDO.SubService]
│   │   │   │   │       └── Widgets: BDO.Widget.TrendingTopicsCarousel
│   │   │   │   └── /საქართველოში/Advisory/Global-forensics/Anti-Money-Laundering  [BDO.Service]
│   │   │   │       └── Widgets: BDO.Widget.RichText
│   │   │   ├── /საქართველოში/Advisory/Cybersecurity  [BDO.ServiceArea]
│   │   │   │   └── Widgets: BDO.Widget.RelatedContentCarousel
│   │   │   │   └── /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking  [BDO.Service]
│   │   │   │       └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.TrendingTopicsCarousel
│   │   │   │       └── /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking/Sub-Service  [BDO.SubService]
│   │   │   │           └── Widgets: BDO.Widget.EditorsPick, BDO.Widget.RelatedContentCarousel, BDO.Widget.ViewGlobalLocations
│   │   │   └── /საქართველოში/Advisory/BDO-Digital  [BDO.ServiceArea]
│   │   │       └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider
│   │   └── /საქართველოში/Lape-Business-Line  [BDO.BusinessLine]
│   │       └── Widgets: BDO.Widget.EventsWebinarsSlider, BDO.Widget.InsightCarousel, BDO.Widget.TrendingTopicsCarousel
│   │       ├── /საქართველოში/Lape-Business-Line/ÆæAaaeOU2c2  [BDO.ServiceArea]
│   │       ├── /საქართველოში/Lape-Business-Line/aaæAaAOU2c  [BDO.ServiceArea]
│   │       ├── /საქართველოში/Lape-Business-Line/ÆæAaAØ  [BDO.ServiceArea]
│   │       └── /საქართველოში/Lape-Business-Line/Lape-Service-Area  [BDO.ServiceArea]
│   │           └── Widgets: BDO.Widget.RichText
│   │           └── /საქართველოში/Lape-Business-Line/Lape-Service-Area/Lape-Service  [BDO.Service]
│   │               └── Widgets: BDO.Widget.HTML, BDO.Widget.RelatedContentCarousel
│   ├── /Industries  [BDO.SectionIndustries]
│   │   └── Widgets: BDO.Widget.TiledLinkSection
│   │   ├── /Industries/JJ-Industry-Category  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.EventsWebinarsSlider
│   │   │   ├── /Industries/JJ-Industry-Category/JJ-Explorer-Quarterly-Cash-Updates-(1)  [BDO.Industry]
│   │   │   │   ├── /Industries/JJ-Industry-Category/JJ-Explorer-Quarterly-Cash-Updates-(1)/industry-service-2  [BDO.IndustryService]
│   │   │   │   └── /Industries/JJ-Industry-Category/JJ-Explorer-Quarterly-Cash-Updates-(1)/Industry-service  [BDO.IndustryService]
│   │   │   │       └── Widgets: BDO.Widget.RichText
│   │   │   └── /Industries/JJ-Industry-Category/JJ-Explorer-Quarterly-Cash-Updates  [BDO.Industry]
│   │   ├── /Industries/Gated-downloads  [BDO.ThankYouConversionPages]
│   │   │   └── /Industries/Gated-downloads/Download-the-report  [BDO.ThankYouConversionPage]
│   │   │       └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.InsightCarousel
│   │   ├── /Industries/Lape-Industries  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts, BDO.Widget.TrendingTopicsCarousel
│   │   ├── /Industries/RK-Category-1  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.KeyContacts, BDO.Widget.RelatedContentCarousel, BDO.Widget.RelatedContacts, BDO.Widget.TiledLinkSection, BDO.Widget.TabAccordion, Kentico.FormWidget, BDO.Widget.ImageWithText, BDO.Widget.RichText
│   │   │   └── /Industries/RK-Category-1/RK-Industry  [BDO.Industry]
│   │   │       └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.RelatedContentCarousel, BDO.Widget.ImageWithText
│   │   │       └── /Industries/RK-Category-1/RK-Industry/RK-Industry-service  [BDO.IndustryService]
│   │   ├── /Industries/Test  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.ImageWithText, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.TabAccordion, BDO.Widget.RelatedContentCarousel
│   │   ├── /Industries/Shipping-and-Transport  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel, BDO.Widget.QuoteCard, BDO.Widget.RichText, BDO.Widget.TabAccordion
│   │   │   └── /Industries/Shipping-and-Transport/Industry-1-child  [BDO.Industry]
│   │   │       └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RelatedContentCarousel
│   │   │       ├── /Industries/Shipping-and-Transport/Industry-1-child/Industry-2nd-child  [BDO.IndustryService]
│   │   │       └── /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2  [BDO.IndustryService]
│   │   │           └── Widgets: BDO.Widget.TiledLinkSection
│   │   ├── /Industries/Not-for-profit  [BDO.IndustryCategory]
│   │   ├── /Industries/Professional-services  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.Accordion, BDO.Widget.EditorsPick, BDO.Widget.InsightCarousel
│   │   ├── /Industries/Manufacturing  [BDO.IndustryCategory]
│   │   ├── /Industries/Healthcare  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel
│   │   ├── /Industries/Public-sector  [BDO.IndustryCategory]
│   │   ├── /Industries/Technology,-Media-Entertainment,-Telecommunication  [BDO.IndustryCategory]
│   │   ├── /Industries/Private-Equity  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.TabAccordion
│   │   ├── /Industries/Real-Estate-Construction  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.TabAccordion, BDO.Widget.RichText, BDO.Widget.FlexibleContent
│   │   ├── /Industries/Automotive  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.TabAccordion
│   │   │   └── /Industries/Automotive/Industry  [BDO.Industry]
│   │   │       └── Widgets: BDO.Widget.TabAccordion, BDO.Widget.InsightCarousel
│   │   ├── /Industries/Consumer-Services  [BDO.IndustryCategory]
│   │   │   └── Widgets: BDO.Widget.RichText, Kentico.FormWidget, BDO.Widget.KeyContacts
│   │   │   ├── /Industries/Consumer-Services/Delivery-Services  [BDO.Industry]
│   │   │   │   └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.Button, BDO.Widget.RichText, BDO.Widget.TrendingTopicsCarousel
│   │   │   │   └── /Industries/Consumer-Services/Delivery-Services/Industry-Service  [BDO.IndustryService]
│   │   │   │       └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.Button, BDO.Widget.RichText
│   │   │   └── /Industries/Consumer-Services/Food  [BDO.Industry]
│   │   └── /Industries/Financial-Services  [BDO.IndustryCategory]
│   │       └── Widgets: BDO.Widget.InsightCarousel
│   │       ├── /Industries/Financial-Services/Industry-1  [BDO.Industry]
│   │       ├── /Industries/Financial-Services/z-industry  [BDO.Industry]
│   │       ├── /Industries/Financial-Services/LLL-industry  [BDO.Industry]
│   │       └── /Industries/Financial-Services/zzz-industry  [BDO.Industry]
│   ├── /Specialties  [BDO.SectionSpecialties]
│   │   └── Widgets: BDO.Widget.FlexibleContent, BDO.Widget.EditorsPick
│   │   ├── /Specialties/BDO-Digital  [BDO.SpecialtiesCategory]
│   │   │   └── Widgets: BDO.Widget.TabAccordion
│   │   │   └── /Specialties/BDO-Digital/Cybersecurity  [BDO.SpecialtiesArea]
│   │   │       └── Widgets: BDO.Widget.FlexibleBanner, BDO.Widget.EditorsPick, BDO.Widget.QuoteCard
│   │   ├── /Specialties/The-title-longer-than-26-symbols  [BDO.SpecialtiesCategory]
│   │   ├── /Specialties/Gemeinnutzigkeitsrechtsreform2  [BDO.SpecialtiesCategory]
│   │   ├── /Specialties/Renditions  [BDO.SpecialtiesCategory]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   │   ├── /Specialties/Renditions/Spec-area  [BDO.SpecialtiesArea]
│   │   │   └── /Specialties/Renditions/RK-Specialty-Category  [BDO.SpecialtiesArea]
│   │   └── /Specialties/Category  [BDO.SpecialtiesCategory]
│   │       ├── /Specialties/Category/KR-Speialties  [BDO.SpecialtiesArea]
│   │       │   └── Widgets: BDO.Widget.RichText, BDO.Widget.KeyContacts
│   │       │   ├── /Specialties/Category/KR-Speialties/Specialty-page-2  [BDO.SpecialtiesPage]
│   │       │   └── /Specialties/Category/KR-Speialties/General  [BDO.SpecialtiesPage]
│   │       └── /Specialties/Category/Specialties-areas  [BDO.SpecialtiesArea]
│   │           ├── /Specialties/Category/Specialties-areas/RK-Specialty-page  [BDO.SpecialtiesPage]
│   │           │   └── Widgets: BDO.Widget.FlexibleContent
│   │           └── /Specialties/Category/Specialties-areas/Specialties-page  [BDO.SpecialtiesPage]
│   ├── /RK-Downloads  [BDO.ThankYouConversionPages]
│   ├── /Business-Strategies  [BDO.SectionBusinessStrategies]
│   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.ViewGlobalLocations, BDO.Widget.EditorsPick, BDO.Widget.ImageWithText
│   │   ├── /Business-Strategies/Lape-Business-Strategy  [BDO.BusinessStrategy]
│   │   ├── /Business-Strategies/Gated-Download  [BDO.ThankYouConversionPage]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText
│   │   ├── /Business-Strategies/thank-(1)  [BDO.ThankYouConversionPages]
│   │   │   └── /Business-Strategies/thank-(1)/you  [BDO.ThankYouConversionPage]
│   │   ├── /Business-Strategies/Thank  [BDO.ThankYouConversionPages]
│   │   │   └── /Business-Strategies/Thank/you  [BDO.ThankYouConversionPage]
│   │   ├── /Business-Strategies/Category-2  [BDO.BusinessStrategiesCategory]
│   │   │   ├── /Business-Strategies/Category-2/New-Business-Strategy  [BDO.BusinessStrategy]
│   │   │   │   └── Widgets: BDO.Widget.TabAccordion
│   │   │   └── /Business-Strategies/Category-2/Comply-with-Regulations  [BDO.BusinessStrategy]
│   │   └── /Business-Strategies/Business-Strategy-Category  [BDO.BusinessStrategiesCategory]
│   │       ├── /Business-Strategies/Business-Strategy-Category/Evolve-Your-Operation  [BDO.BusinessStrategy]
│   │       │   └── Widgets: BDO.Widget.RichText, BDO.Widget.EventsWebinarsSlider, Kentico.FormWidget
│   │       ├── /Business-Strategies/Business-Strategy-Category/Perform-to-Expectations  [BDO.BusinessStrategy]
│   │       ├── /Business-Strategies/Business-Strategy-Category/Business-Strategy  [BDO.BusinessStrategy]
│   │       │   └── Widgets: BDO.Widget.RichText, BDO.Widget.InsightCarousel, BDO.Widget.FlexibleBanner
│   │       ├── /Business-Strategies/Business-Strategy-Category/Das-Hinweisgeberschutzgesetz-ist-da!  [BDO.BusinessStrategy]
│   │       ├── /Business-Strategies/Business-Strategy-Category/BusinessStrategyPageLongTitleWithoutSpaces  [BDO.BusinessStrategy]
│   │       ├── /Business-Strategies/Business-Strategy-Category/Business-Strategy-page-Long-title  [BDO.BusinessStrategy]
│   │       ├── /Business-Strategies/Business-Strategy-Category/PRASENSVERANSTALTUNG29symbols  [BDO.BusinessStrategy]
│   │       └── /Business-Strategies/Business-Strategy-Category/PRASENSVERANSTALTUNG27symbo  [BDO.BusinessStrategy]
│   ├── /Section-Legal  [BDO.SectionLegal]
│   │   ├── /Section-Legal/Privacy-Policy  [BDO.LegalPage]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   └── /Section-Legal/Cookies  [BDO.LegalPage]
│   ├── /Testimonials  [BDO.SectionTestimonials]
│   │   └── /Testimonials/Testimonial  [BDO.TestimonialType]
│   │       └── /Testimonials/Testimonial/Testimonial-page  [BDO.Testimonial]
│   ├── /Thank-you  [BDO.ThankYouConversionPages]
│   │   ├── /Thank-you/JJ-Thank-You-page  [BDO.ThankYouConversionPage]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText
│   │   ├── /Thank-you/Matas-thank-you-page  [BDO.ThankYouConversionPage]
│   │   └── /Thank-you/Thank-you-Conversion-page  [BDO.ThankYouConversionPage]
│   │       └── Widgets: BDO.Widget.Hero
│   ├── /Deals  [BDO.SectionDeals]
│   │   └── Widgets: BDO.Widget.Hero
│   │   ├── /Deals/MV-Deal-EN  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   ├── /Deals/MV-Deal-LT-checked-in  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.TrendingTopicsCarousel
│   │   ├── /Deals/MV-Deal-LT  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.Accordion, BDO.Widget.ImageWithText, BDO.Widget.EditorsPick, BDO.Widget.SocialMediaButtons
│   │   ├── /Deals/MV-Deal-3-(2)  [BDO.Deal]
│   │   │   └── Linked -> /Deals/MV-Deal-3 [BDO.Deal]
│   │   ├── /Deals/MV-Deal-3-(1)  [BDO.Deal]
│   │   ├── /Deals/MV-Deal-3  [BDO.Deal]
│   │   ├── /Deals/JJ-Deal-(1)  [BDO.DealFolder]
│   │   │   └── /Deals/JJ-Deal-(1)/JJ-Deal-12-June-2025  [BDO.Deal]
│   │   │       └── Widgets: BDO.Widget.KeyContacts
│   │   ├── /Deals/MV-Deal-2  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   ├── /Deals/MV-Deal  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.TiledLinkSection
│   │   ├── /Deals/Lape-Demo-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/Advice-Allegion-in-the-acquisition-of-Dorcas  [BDO.RemoteDeal]
│   │   ├── /Deals/DealU  [BDO.RemoteDeal]
│   │   ├── /Deals/Acquisition-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/Lape-Integrations-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/Deal-Test-from-Integration  [BDO.RemoteDeal]
│   │   ├── /Deals/Deal-From-Integrations-For-demo  [BDO.RemoteDeal]
│   │   ├── /Deals/Lape-BDO-WOW-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/Deal-to-test-RSS  [BDO.Deal]
│   │   ├── /Deals/Lape-GWT-DEV-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/Deal-From-DEV-For-demo  [BDO.RemoteDeal]
│   │   ├── /Deals/AU-DEV-EV-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/DEV-EV-Deal-4-Not-indexed  [BDO.RemoteDeal]
│   │   ├── /Deals/DEV-EV-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/English-Deal  [BDO.RemoteDeal]
│   │   ├── /Deals/Australian-Deal-2  [BDO.RemoteDeal]
│   │   ├── /Deals/Australian-Deal-1  [BDO.RemoteDeal]
│   │   ├── /Deals/Deal-to-Synchronize  [BDO.RemoteDeal]
│   │   ├── /Deals/Lape-Deal-(2)  [BDO.RemoteDeal]
│   │   ├── /Deals/JJ-Deal-2  [BDO.Deal]
│   │   ├── /Deals/JJ-Deal  [BDO.Deal]
│   │   ├── /Deals/New-Deal-EV  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.Button, BDO.Widget.KeyContacts
│   │   ├── /Deals/Example-Deal-Folder  [BDO.DealFolder]
│   │   │   └── /Deals/Example-Deal-Folder/Deal-Under-Folder  [BDO.Deal]
│   │   ├── /Deals/Lape-Deal-(1)  [BDO.Deal]
│   │   ├── /Deals/2023  [BDO.Deal]
│   │   ├── /Deals/Deal-2018  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.RichText
│   │   ├── /Deals/Deal-2015  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.Button, BDO.Widget.RichText, BDO.Widget.FlexibleBanner, BDO.Widget.KeyContacts, BDO.Widget.QuoteCard, BDO.Widget.RelatedContacts
│   │   ├── /Deals/Deal-cards-sorting-new  [BDO.Deal]
│   │   ├── /Deals/Deal-cards-sorting  [BDO.Deal]
│   │   │   └── Widgets: BDO.Widget.QuoteCard
│   │   ├── /Deals/BDO-advises-Green-Landscaping-Group-AB-on-its-mark  [BDO.Deal]
│   │   ├── /Deals/Cleo-Diagnostics-Limited-completes-its-listing-of  [BDO.Deal]
│   │   ├── /Deals/Acquisition-of-SAS-Eurotandem-by-investment-fund-C  [BDO.Deal]
│   │   ├── /Deals/Deal-LT  [BDO.Deal]
│   │   ├── /Deals/Deal-w-o-logo  [BDO.Deal]
│   │   ├── /Deals/New-Deal  [BDO.Deal]
│   │   └── /Deals/Lape-Deal  [BDO.Deal]
│   ├── /About-Us  [BDO.SectionAbout]
│   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.InsightCarousel, Kentico.FormWidget, BDO.Widget.EventsWebinarsSlider, BDO.Widget.TiledLinkSection
│   │   ├── /About-Us/Affected-about-us-page  [BDO.AboutPage]
│   │   ├── /About-Us/Our-culture  [BDO.AboutPage]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.RichText, BDO.Widget.ImageWithText
│   │   ├── /About-Us/JJ-About  [BDO.AboutPage]
│   │   │   └── Widgets: BDO.Widget.NewsCarousel, BDO.Widget.KeyContacts, BDO.Widget.RichText, BDO.Widget.SocialMediaButtons, Kentico.FormWidget, BDO.Widget.QuoteCard, BDO.Widget.FlexibleBanner, BDO.Widget.ImageWithText, BDO.Widget.HTML, BDO.Widget.EditorsPick, BDO.Widget.InFocus
│   │   │   ├── /About-Us/JJ-About/FAQ  [BDO.AboutPage]
│   │   │   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.Accordion
│   │   │   ├── /About-Us/JJ-About/Test-BDO-Consent  [BDO.AboutPage]
│   │   │   │   └── Widgets: Kentico.FormWidget
│   │   │   └── /About-Us/JJ-About/JJ-About-Widgets  [BDO.AboutPage]
│   │   │       └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.InFocus
│   │   ├── /About-Us/MP-About  [BDO.AboutPage]
│   │   │   └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.HTML, BDO.Widget.TabAccordion, BDO.Widget.RichText, BDO.Widget.InFocus
│   │   └── /About-Us/About-page  [BDO.AboutPage]
│   │       └── Widgets: BDO.Widget.TiledLinkSection, BDO.Widget.HTML, BDO.Widget.InsightCarousel, BDO.Widget.ViewGlobalLocations
│   │       └── /About-Us/About-page/New-About  [BDO.AboutPage]
│   │           └── Widgets: BDO.Widget.RichText
│   ├── /Global-locations  [BDO.GlobalLocations]
│   ├── /Search  [BDO.Search]
│   ├── /Contact-Us  [BDO.Contact]
│   ├── /Events  [BDO.SectionEvents]
│   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.HTML
│   │   ├── /Events/Event-EV-7-6-2  [BDO.Event]
│   │   │   └── /Events/Event-EV-7-6-2/Event-EV-7-6-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/Jerard-Event-Test  [BDO.Event]
│   │   ├── /Events/MV-Event  [BDO.Event]
│   │   │   └── /Events/MV-Event/MV-Event-registration-form  [BDO.EventRegistrationForm]
│   │   ├── /Events/JV-Event-2  [BDO.Event]
│   │   │   └── /Events/JV-Event-2/JV-Event-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/JV-Event-(1)  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.Hero
│   │   │   └── /Events/JV-Event-(1)/JV-Event  [BDO.EventRegistrationForm]
│   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(4)  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(4)/KR-2023-Risk,-Resilience-Recovery-Webcast-(1)  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(4)/KR-2023-Risk,-Resilience-Recovery-Webcast  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(4)/Ms-Jenny-Smithie  [BDO.Presenter]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(4)/Mr-John-Smith  [BDO.Presenter]
│   │   │   └── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(4)/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo  [BDO.EventRegistrationForm]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(3)  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(3)/KR-2023-Risk,-Resilience-Recovery-Webcast-(1)  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(3)/KR-2023-Risk,-Resilience-Recovery-Webcast  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(3)/Ms-Jenny-Smithie  [BDO.Presenter]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(3)/Mr-John-Smith  [BDO.Presenter]
│   │   │   └── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(3)/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo  [BDO.EventRegistrationForm]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(2)  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation, BDO.Widget.Hero
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(2)/KR-2023-Risk,-Resilience-Recovery-Webcast-(1)  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(2)/KR-2023-Risk,-Resilience-Recovery-Webcast  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(2)/Ms-Jenny-Smithie  [BDO.Presenter]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(2)/Mr-John-Smith  [BDO.Presenter]
│   │   │   └── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(2)/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo  [BDO.EventRegistrationForm]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(1)  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(1)/KR-2023-Risk,-Resilience-Recovery-Webcast  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(1)/Ms-Jenny-Smithie  [BDO.Presenter]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(1)/Mr-John-Smith  [BDO.Presenter]
│   │   │   └── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-(1)/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo  [BDO.EventRegistrationForm]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Events/even-3  [BDO.Event]
│   │   ├── /Events/Event-A-20-(1)  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.LocalNavigation
│   │   │   ├── /Events/Event-A-20-(1)/Event-A-20-(1)  [BDO.EventRegistrationForm]
│   │   │   └── /Events/Event-A-20-(1)/Event-A-20  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-20  [BDO.Event]
│   │   │   └── /Events/Event-A-20/Event-A-20  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-19  [BDO.Event]
│   │   │   └── /Events/Event-A-19/Event-A-19  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-18  [BDO.Event]
│   │   │   └── /Events/Event-A-18/Event-A-18  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-17  [BDO.Event]
│   │   │   └── /Events/Event-A-17/Event-A-17  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-16  [BDO.Event]
│   │   │   └── /Events/Event-A-16/Event-A-16  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-15  [BDO.Event]
│   │   │   └── /Events/Event-A-15/Event-A-15  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-14  [BDO.Event]
│   │   │   └── /Events/Event-A-14/Event-A-14  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-13  [BDO.Event]
│   │   │   └── /Events/Event-A-13/Event-A-13  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-12  [BDO.Event]
│   │   │   └── /Events/Event-A-12/Event-A-12  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-11  [BDO.Event]
│   │   │   └── /Events/Event-A-11/Event-A-11  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-10  [BDO.Event]
│   │   │   └── /Events/Event-A-10/Event-A-10  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-9  [BDO.Event]
│   │   │   └── /Events/Event-A-9/Event-A-9  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-8  [BDO.Event]
│   │   │   └── /Events/Event-A-8/Event-A-8  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-7  [BDO.Event]
│   │   │   └── /Events/Event-A-7/Event-A-7  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-6  [BDO.Event]
│   │   │   └── /Events/Event-A-6/Event-A-6  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-5  [BDO.Event]
│   │   │   └── /Events/Event-A-5/Event-A-5  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-4  [BDO.Event]
│   │   │   └── /Events/Event-A-4/Event-A-4  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-3  [BDO.Event]
│   │   │   └── /Events/Event-A-3/Event-A-3  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-2  [BDO.Event]
│   │   │   └── /Events/Event-A-2/Event-A-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-A-1  [BDO.Event]
│   │   │   └── /Events/Event-A-1/Event-A-1  [BDO.EventRegistrationForm]
│   │   ├── /Events/External-test  [BDO.Event]
│   │   ├── /Events/Event-with-external  [BDO.Event]
│   │   ├── /Events/Testing-part-2-(3)  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/Testing-part-2-(3)/Testing-Hero-w-Hero-w-CTA-3rd  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/Testing-part-2-(3)/Testing-Hero-w-banner-w-CTA-2nd  [BDO.EventRegistrationForm]
│   │   │   └── /Events/Testing-part-2-(3)/Testing-part-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/Testing-part-2-(2)  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/Testing-part-2-(2)/Testing-Hero-w-banner-w-CTA-2nd  [BDO.EventRegistrationForm]
│   │   │   └── /Events/Testing-part-2-(2)/Testing-part-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/Testing-part-2-(1)  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/Testing-part-2-(1)/Testing-Hero-w-banner-and-image-NO-CTA  [BDO.EventRegistrationForm]
│   │   │   └── /Events/Testing-part-2-(1)/Testing-part-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/Testing-part-2  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/Testing-part-2/Testing-part-2  [BDO.EventRegistrationForm]
│   │   ├── /Events/Title  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/Title/Title  [BDO.EventRegistrationForm]
│   │   ├── /Events/JV-Event  [BDO.Event]
│   │   │   └── /Events/JV-Event/JV-Event  [BDO.EventRegistrationForm]
│   │   ├── /Events/Event-EV-1  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.EventsWebinarsSlider, BDO.Widget.Hero
│   │   │   ├── /Events/Event-EV-1/Presenter-one-(1)  [BDO.Presenter]
│   │   │   ├── /Events/Event-EV-1/Presenter-one  [BDO.Presenter]
│   │   │   └── /Events/Event-EV-1/Event-EV-1  [BDO.EventRegistrationForm]
│   │   ├── /Events/New-Webinar-with-recording  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/New-Webinar-with-recording/New-Webinar-with-recording  [BDO.EventRegistrationForm]
│   │   ├── /Events/Lape-Event  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/Lape-Event/Lape-Event  [BDO.EventRegistrationForm]
│   │   ├── /Events/Webinar-On-Demand  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/Webinar-On-Demand/Webinar-On-Demand  [BDO.EventRegistrationForm]
│   │   ├── /Events/VIP-Webinar  [BDO.Webinar]
│   │   │   └── /Events/VIP-Webinar/VIP-Webinar  [BDO.EventRegistrationForm]
│   │   ├── /Events/RK-Event  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/RK-Event/RK-Event  [BDO.EventRegistrationForm]
│   │   ├── /Events/Lape-Webinar  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.HTML, BDO.Widget.Hero
│   │   │   └── /Events/Lape-Webinar/Lape-Webinar  [BDO.EventRegistrationForm]
│   │   ├── /Events/webinar-1  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/webinar-1/webinar-1-(1)  [BDO.EventRegistrationForm]
│   │   │   └── /Events/webinar-1/webinar-1  [BDO.EventRegistrationForm]
│   │   ├── /Events/Test-1  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /Events/Test-1/Test-1  [BDO.EventRegistrationForm]
│   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo/KR-2023-Risk,-Resilience-Recovery-Webcast  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo/Ms-Jenny-Smithie  [BDO.Presenter]
│   │   │   ├── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo/Mr-John-Smith  [BDO.Presenter]
│   │   │   └── /Events/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo/2023-Risk,-Resilience-Recovery-Webcast-Series-Beyo  [BDO.EventRegistrationForm]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Events/2023-State-of-the-Healthcare-Industry-Compliance-C  [BDO.Event]
│   │   │   └── Widgets: BDO.Widget.HTML, BDO.Widget.Hero
│   │   │   ├── /Events/2023-State-of-the-Healthcare-Industry-Compliance-C/KR-2023-State-of-the-Healthcare-Industry-Complianc  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-State-of-the-Healthcare-Industry-Compliance-C/2023-State-of-the-Healthcare-Industry-Compliance-C  [BDO.EventRegistrationForm]
│   │   │   ├── /Events/2023-State-of-the-Healthcare-Industry-Compliance-C/Mr-Presenter  [BDO.Presenter]
│   │   │   └── /Events/2023-State-of-the-Healthcare-Industry-Compliance-C/John-Smith  [BDO.Presenter]
│   │   ├── /Events/EV-Webinar-1  [BDO.Webinar]
│   │   │   └── Widgets: BDO.Widget.EventsWebinarsSlider
│   │   │   ├── /Events/EV-Webinar-1/Lukas-Wiederhold  [BDO.Presenter]
│   │   │   ├── /Events/EV-Webinar-1/Christian-Trost  [BDO.Presenter]
│   │   │   └── /Events/EV-Webinar-1/EV-Webinar-1  [BDO.EventRegistrationForm]
│   │   └── /Events/JJ-Events  [BDO.EventWebinarFolder]
│   │       ├── /Events/JJ-Events/JJ-Event  [BDO.Event]
│   │       │   └── /Events/JJ-Events/JJ-Event/JJ-Event  [BDO.EventRegistrationForm]
│   │       └── /Events/JJ-Events/Webinar  [BDO.Webinar]
│   │           └── Widgets: BDO.Widget.Hero
│   │           ├── /Events/JJ-Events/Webinar/Another-form  [BDO.EventRegistrationForm]
│   │           ├── /Events/JJ-Events/Webinar/Nicole-Potts  [BDO.Presenter]
│   │           └── /Events/JJ-Events/Webinar/Webinar-(1)  [BDO.EventRegistrationForm]
│   ├── /Reusable-Content-Tab  [CMS.Folder]
│   ├── /Blogs  [BDO.SectionBlogs]
│   │   ├── /Blogs/Lape-Blog  [BDO.Blog]
│   │   │   └── /Blogs/Lape-Blog/Lape-Blog-Post-Group  [BDO.BlogPostGroup]
│   │   │       └── /Blogs/Lape-Blog/Lape-Blog-Post-Group/Lape-Blog-Post  [BDO.BlogPost]
│   │   ├── /Blogs/New-blog-for-testing  [BDO.Blog]
│   │   │   └── /Blogs/New-blog-for-testing/Blog-post-group  [BDO.BlogPostGroup]
│   │   ├── /Blogs/Blog  [BDO.Blog]
│   │   ├── /Blogs/RK-Blog  [BDO.Blog]
│   │   │   ├── /Blogs/RK-Blog/Contributors  [BDO.BlogContributors]
│   │   │   │   ├── /Blogs/RK-Blog/Contributors/Bio-page  [BDO.Person]
│   │   │   │   │   └── Linked -> /Our-People/Bio-page [BDO.Person]
│   │   │   │   ├── /Blogs/RK-Blog/Contributors/Demo-Example-(1)  [BDO.Person]
│   │   │   │   ├── /Blogs/RK-Blog/Contributors/Demo-Example  [BDO.Person]
│   │   │   │   ├── /Blogs/RK-Blog/Contributors/Person-from-blogs  [BDO.Person]
│   │   │   │   └── /Blogs/RK-Blog/Contributors/Tadas-Lape  [BDO.Person]
│   │   │   └── /Blogs/RK-Blog/RK-Blogs  [BDO.BlogPostGroup]
│   │   │       ├── /Blogs/RK-Blog/RK-Blogs/Blog-Post  [BDO.BlogPost]
│   │   │       └── /Blogs/RK-Blog/RK-Blogs/RK-Blog-Post  [BDO.BlogPost]
│   │   │           └── Widgets: BDO.Widget.Hero, Kentico.FormWidget, BDO.Widget.SocialMediaButtons
│   │   ├── /Blogs/Technology-Services-Analyst  [BDO.Blog]
│   │   ├── /Blogs/BDO-Healthcare  [BDO.Blog]
│   │   │   ├── /Blogs/BDO-Healthcare/Health-and-Safety  [BDO.BlogPostGroup]
│   │   │   │   └── /Blogs/BDO-Healthcare/Health-and-Safety/Health-and-Safety  [BDO.BlogPost]
│   │   │   ├── /Blogs/BDO-Healthcare/Contributors  [BDO.BlogContributors]
│   │   │   │   ├── /Blogs/BDO-Healthcare/Contributors/Person1  [BDO.Person]
│   │   │   │   │   └── Linked -> /Our-People/Person1 [BDO.Person]
│   │   │   │   ├── /Blogs/BDO-Healthcare/Contributors/Vardenis-Pavardenis  [BDO.Person]
│   │   │   │   ├── /Blogs/BDO-Healthcare/Contributors/Blog-Person  [BDO.Person]
│   │   │   │   └── /Blogs/BDO-Healthcare/Contributors/Partner-Feng-Ch-eng  [BDO.Person]
│   │   │   └── /Blogs/BDO-Healthcare/Healthcare  [BDO.BlogPostGroup]
│   │   │       └── /Blogs/BDO-Healthcare/Healthcare/Health-Service-Capacity-Review-and-its-Impact  [BDO.BlogPost]
│   │   │           └── Widgets: BDO.Widget.Hero, BDO.Widget.FlexibleContent, BDO.Widget.EditorsPick
│   │   ├── /Blogs/IT-Blogs  [BDO.Blog]
│   │   │   ├── /Blogs/IT-Blogs/Smartphones  [BDO.BlogPostGroup]
│   │   │   │   ├── /Blogs/IT-Blogs/Smartphones/Where-can-I-get-some  [BDO.BlogPost]
│   │   │   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.InsightCarousel
│   │   │   │   ├── /Blogs/IT-Blogs/Smartphones/Focus-on-Fair-Deal-for-Nursing-Homes  [BDO.BlogPost]
│   │   │   │   ├── /Blogs/IT-Blogs/Smartphones/New-blog-post  [BDO.BlogPost]
│   │   │   │   │   └── Widgets: BDO.Widget.InsightCarousel
│   │   │   │   └── /Blogs/IT-Blogs/Smartphones/Smartphones-Blog  [BDO.BlogPost]
│   │   │   ├── /Blogs/IT-Blogs/John-Smith  [BDO.BlogContributors]
│   │   │   │   ├── /Blogs/IT-Blogs/John-Smith/Dr  [BDO.Person]
│   │   │   │   └── /Blogs/IT-Blogs/John-Smith/CEO  [BDO.Person]
│   │   │   ├── /Blogs/IT-Blogs/IT-Blogs-RSS  [BDO.Rss]
│   │   │   └── /Blogs/IT-Blogs/Title  [BDO.Contact]
│   │   └── /Blogs/Tech-Media-Watch-Blog  [BDO.Blog]
│   │       ├── /Blogs/Tech-Media-Watch-Blog/RSS  [BDO.Rss]
│   │       ├── /Blogs/Tech-Media-Watch-Blog/Group  [BDO.BlogPostGroup]
│   │       │   └── /Blogs/Tech-Media-Watch-Blog/Group/Five-trends-defining-TMT-companies’-reward-and-rem  [BDO.BlogPost]
│   │       │       └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText
│   │       ├── /Blogs/Tech-Media-Watch-Blog/Contributors  [BDO.BlogContributors]
│   │       │   ├── /Blogs/Tech-Media-Watch-Blog/Contributors/Juanita-House  [BDO.Person]
│   │       │   │   └── Linked -> /Our-People/Juanita-House [BDO.Person]
│   │       │   └── /Blogs/Tech-Media-Watch-Blog/Contributors/Kimberly-Nunez  [BDO.Person]
│   │       └── /Blogs/Tech-Media-Watch-Blog/Contact-Us  [BDO.Contact]
│   ├── /Subscribe-to-BDO-News  [BDO.Contact]
│   ├── /Locations  [BDO.Locations]
│   │   └── Widgets: BDO.Widget.Button, BDO.Widget.FlexibleContent, Kentico.FormWidget
│   │   ├── /Locations/Schema-test-city  [BDO.LocationCity]
│   │   │   └── /Locations/Schema-test-city/Schema-test-office  [BDO.LocationOffice]
│   │   ├── /Locations/Kaunas-(1)  [BDO.LocationCity]
│   │   │   └── Widgets: BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider
│   │   │   └── /Locations/Kaunas-(1)/Vilnius  [BDO.LocationOffice]
│   │   ├── /Locations/Kaunas  [BDO.LocationCity]
│   │   │   └── Widgets: BDO.Widget.RelatedContacts, BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider
│   │   │   ├── /Locations/Kaunas/BDO-Klaipeda  [BDO.LocationOffice]
│   │   │   ├── /Locations/Kaunas/Vilnius  [BDO.LocationOffice]
│   │   │   └── /Locations/Kaunas/BDO-Kaunas  [BDO.LocationOffice]
│   │   ├── /Locations/Location-city-(3)  [BDO.LocationCity]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.EditorsPick, BDO.Widget.EventsWebinarsSlider, BDO.Widget.HTML, BDO.Widget.ViewGlobalLocations, BDO.Widget.RelatedContacts, BDO.Widget.ImageWithText
│   │   │   ├── /Locations/Location-city-(3)/BDO-Southern-Lakes-Central-Otago-Alexandra  [BDO.LocationOffice]
│   │   │   └── /Locations/Location-city-(3)/Location-office  [BDO.LocationOffice]
│   │   ├── /Locations/Location-city-(2)  [BDO.LocationCity]
│   │   │   └── /Locations/Location-city-(2)/Location-Office  [BDO.LocationOffice]
│   │   ├── /Locations/Test-Location  [BDO.LocationCity]
│   │   │   ├── /Locations/Test-Location/Office2  [BDO.LocationOffice]
│   │   │   └── /Locations/Test-Location/Office  [BDO.LocationOffice]
│   │   ├── /Locations/Location-City  [BDO.LocationCity]
│   │   │   └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.RelatedContacts, BDO.Widget.EventsWebinarsSlider
│   │   │   ├── /Locations/Location-City/Regent-Street  [BDO.LocationOffice]
│   │   │   └── /Locations/Location-City/Location-Office  [BDO.LocationOffice]
│   │   └── /Locations/API  [BDO.LocationCity]
│   │       └── Widgets: BDO.Widget.RelatedContacts
│   │       ├── /Locations/API/API-1-title-(1)  [BDO.LocationOffice]
│   │       └── /Locations/API/API-1-title  [BDO.LocationOffice]
│   ├── /Microsites-staging  [BDO.SectionMicrosites]
│   │   └── /Microsites-staging/Microsite-Master-Page  [BDO.MicrositeMasterPage]
│   │       └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.Accordion, BDO.Widget.InsightCarousel
│   │       └── /Microsites-staging/Microsite-Master-Page/Microsite-page  [BDO.MicrositePage]
│   │           └── Widgets: BDO.Widget.Hero, BDO.Widget.InsightCarousel, BDO.Widget.Accordion, BDO.Widget.QuoteCard, BDO.Widget.RichText, BDO.Widget.KeyContacts, BDO.Widget.Button, BDO.Widget.HTML
│   │           ├── /Microsites-staging/Microsite-Master-Page/Microsite-page/Microsite_page  [BDO.MicrositePage]
│   │           │   └── Widgets: BDO.Widget.Hero, BDO.Widget.Accordion
│   │           ├── /Microsites-staging/Microsite-Master-Page/Microsite-page/A-(1)  [BDO.MicrositePage]
│   │           ├── /Microsites-staging/Microsite-Master-Page/Microsite-page/a  [BDO.MicrositePage]
│   │           ├── /Microsites-staging/Microsite-Master-Page/Microsite-page/z  [BDO.MicrositePage]
│   │           └── /Microsites-staging/Microsite-Master-Page/Microsite-page/Mirosite-Test  [BDO.MicrositePage]
│   │               └── /Microsites-staging/Microsite-Master-Page/Microsite-page/Mirosite-Test/Microsite-3rd-list-item  [BDO.MicrositePage]
│   │                   └── Widgets: BDO.Widget.RichText, BDO.Widget.KeyContacts
│   ├── /Microsites  [BDO.SectionMicrosites]
│   │   ├── /Microsites/MV-Microsite  [BDO.MicrositeMasterPage]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.LocalNavigation, BDO.Widget.Button, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.TabAccordion, BDO.Widget.EditorsPick, BDO.Widget.RichText, BDO.Widget.SocialMediaButtons
│   │   ├── /Microsites/Lape-Microsite  [BDO.MicrositeMasterPage]
│   │   │   └── Widgets: BDO.Widget.EventsWebinarsSlider, BDO.Widget.Button, BDO.Widget.RelatedContentCarousel, BDO.Widget.EditorsPick, BDO.Widget.InsightCarousel, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContacts
│   │   │   └── /Microsites/Lape-Microsite/Lape-Microsite-Page  [BDO.MicrositePage]
│   │   │       └── Widgets: BDO.Widget.EventsWebinarsSlider, BDO.Widget.RelatedContentCarousel, BDO.Widget.EditorsPick, BDO.Widget.InsightCarousel, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContacts
│   │   │       └── /Microsites/Lape-Microsite/Lape-Microsite-Page/Lape-Microsite-Page-2nd-Level  [BDO.MicrositePage]
│   │   ├── /Microsites/694818_E2E_Microsite  [BDO.MicrositeMasterPage]
│   │   │   └── /Microsites/694818_E2E_Microsite/694818_E2E_Microsite-Page  [BDO.MicrositePage]
│   │   │       └── Widgets: BDO.Widget.ImageWithText, BDO.Widget.FlexibleContent, BDO.Widget.KeyContacts
│   │   ├── /Microsites/New-Master-page  [BDO.MicrositeMasterPage]
│   │   │   └── Widgets: BDO.Widget.FlexibleContent, BDO.Widget.EventsWebinarsSlider
│   │   ├── /Microsites/OG-Master-page  [BDO.MicrositeMasterPage]
│   │   ├── /Microsites/NV  [BDO.MicrositeMasterPage]
│   │   │   └── Widgets: BDO.Widget.TabAccordion, BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContacts, BDO.Widget.EditorsPick
│   │   │   ├── /Microsites/NV/Page-with-comma-,  [BDO.MicrositePage]
│   │   │   ├── /Microsites/NV/2-Page  [BDO.MicrositePage]
│   │   │   │   ├── /Microsites/NV/2-Page/2-2  [BDO.MicrositePage]
│   │   │   │   │   ├── /Microsites/NV/2-Page/2-2/2-2-1-Page  [BDO.MicrositePage]
│   │   │   │   │   ├── /Microsites/NV/2-Page/2-2/2-2-2-Page  [BDO.MicrositePage]
│   │   │   │   │   └── /Microsites/NV/2-Page/2-2/2-2-3-Page  [BDO.MicrositePage]
│   │   │   │   ├── /Microsites/NV/2-Page/3-Page  [BDO.MicrositePage]
│   │   │   │   └── /Microsites/NV/2-Page/2-3-Page  [BDO.MicrositePage]
│   │   │   ├── /Microsites/NV/1-Page  [BDO.MicrositePage]
│   │   │   │   └── Widgets: BDO.Widget.HTML
│   │   │   └── /Microsites/NV/3-Page  [BDO.MicrositePage]
│   │   ├── /Microsites/Test-Social-media-icons  [BDO.MicrositeMasterPage]
│   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RelatedContentCarousel
│   │   │   ├── /Microsites/Test-Social-media-icons/New-JJ-Microsite  [BDO.MicrositePage]
│   │   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText
│   │   │   ├── /Microsites/Test-Social-media-icons/mt  [BDO.MicrositePage]
│   │   │   │   └── Widgets: BDO.Widget.RichText
│   │   │   └── /Microsites/Test-Social-media-icons/Social-media-icons  [BDO.MicrositePage]
│   │   │       └── Widgets: BDO.Widget.Hero, BDO.Widget.HTML, BDO.Widget.KeyContacts, BDO.Widget.TrendingTopicsCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.FlexibleBanner, BDO.Widget.Button, BDO.Widget.FlexibleContent, BDO.Widget.NewsCarousel
│   │   ├── /Microsites/RK-Master-Microsite  [BDO.MicrositeMasterPage]
│   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   ├── /Microsites/RK-Master-Microsite/RK-Microsite-page  [BDO.MicrositePage]
│   │   │   │   └── Widgets: BDO.Widget.Hero, BDO.Widget.RichText, BDO.Widget.FlexibleBanner, BDO.Widget.InsightCarousel, BDO.Widget.TabAccordion
│   │   │   ├── /Microsites/RK-Master-Microsite/1-page  [BDO.MicrositePage]
│   │   │   │   └── /Microsites/RK-Master-Microsite/1-page/2nd-level  [BDO.MicrositePage]
│   │   │   │       ├── /Microsites/RK-Master-Microsite/1-page/2nd-level/4th-level  [BDO.MicrositePage]
│   │   │   │       └── /Microsites/RK-Master-Microsite/1-page/2nd-level/3rd-level  [BDO.MicrositePage]
│   │   │   │           └── Widgets: BDO.Widget.InsightCarousel, BDO.Widget.EventsWebinarsSlider, BDO.Widget.NewsCarousel, BDO.Widget.RelatedContacts
│   │   │   ├── /Microsites/RK-Master-Microsite/2-page  [BDO.MicrositePage]
│   │   │   └── /Microsites/RK-Master-Microsite/3-page  [BDO.MicrositePage]
│   │   │       └── Widgets: BDO.Widget.Hero
│   │   └── /Microsites/MP-Master-Microsite  [BDO.MicrositeMasterPage]
│   │       └── /Microsites/MP-Master-Microsite/MP-Microsite-Page  [BDO.MicrositePage]
│   │           └── Widgets: BDO.Widget.RichText
│   │           └── /Microsites/MP-Master-Microsite/MP-Microsite-Page/MP-Microsite-Child-Page  [BDO.MicrositePage]
│   ├── /News  [BDO.SectionNews]
│   │   ├── /News/Lape-News-Group  [BDO.NewsGroup]
│   │   │   └── /News/Lape-News-Group/Lape-News-Article  [BDO.NewsArticle]
│   │   ├── /News/2024  [BDO.NewsGroup]
│   │   │   ├── /News/2024/JJ-News  [BDO.NewsArticle]
│   │   │   │   └── Widgets: BDO.Widget.RichText
│   │   │   └── /News/2024/Lape-News-Article  [BDO.NewsArticle]
│   │   │       └── Widgets: BDO.Widget.EditorsPick
│   │   ├── /News/IT  [BDO.NewsGroup]
│   │   │   ├── /News/IT/Hvorfor-bruker-vi-det  [BDO.NewsArticle]
│   │   │   └── /News/IT/რა-არის-Lorem-Ipsum  [BDO.NewsArticle]
│   │   │       └── Widgets: BDO.Widget.Hero, Kentico.FormWidget
│   │   ├── /News/Group-3  [BDO.NewsGroup]
│   │   │   ├── /News/Group-3/Relevant-Contact-Person  [BDO.NewsArticle]
│   │   │   │   └── Widgets: BDO.Widget.Hero
│   │   │   └── /News/Group-3/News-article  [BDO.NewsArticle]
│   │   │       └── Widgets: BDO.Widget.KeyContacts, BDO.Widget.RelatedContacts
│   │   ├── /News/Group-2  [BDO.NewsGroup]
│   │   └── /News/Group  [BDO.NewsGroup]
│   │       ├── /News/Group/Publication-about-Lorem-ipsum  [BDO.NewsArticle]
│   │       ├── /News/Group/BDO-Webinare-Pozvanka  [BDO.NewsArticle]
│   │       │   └── Widgets: BDO.Widget.FlexibleBanner
│   │       ├── /News/Group/Article  [BDO.NewsArticle]
│   │       └── /News/Group/Article-2  [BDO.NewsArticle]
│   │           └── Widgets: BDO.Widget.RelatedContacts
│   ├── /Our-People  [BDO.SectionPeoplePage]
│   │   ├── /Our-People/New-API-Test  [BDO.Person]
│   │   ├── /Our-People/Person-JJ  [BDO.Person]
│   │   │   └── Widgets: BDO.Widget.EditorsPick
│   │   ├── /Our-People/Matas-Vaitkus  [BDO.Person]
│   │   ├── /Our-People/Bio-page  [BDO.Person]
│   │   ├── /Our-People/Bert-Haley  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.SocialMediaButtons
│   │   ├── /Our-People/Demo-Example  [BDO.Person]
│   │   ├── /Our-People/Devin-Wintheiser  [BDO.Person]
│   │   ├── /Our-People/Person-Personovich  [BDO.Person]
│   │   ├── /Our-People/Rita-Hodkiewicz  [BDO.Person]
│   │   │   └── Widgets: BDO.Widget.EditorsPick, Kentico.FormWidget
│   │   ├── /Our-People/Lisa-Hayes  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.SocialMediaButtons, BDO.Widget.RichText
│   │   ├── /Our-People/Tadas-Lape-(Broken)  [BDO.Person]
│   │   ├── /Our-People/Tadas-Lape-2  [BDO.Person]
│   │   ├── /Our-People/CAB-Daniel-Danson-(4)  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Our-People/CAB-Daniel-Danson-(3)  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.FlexibleContent
│   │   ├── /Our-People/CAB-Daniel-Danson-(2)  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Our-People/CAB-Daniel-Danson-(1)  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Our-People/ABC-Steve-Johnson-(1)  [BDO.Person]
│   │   ├── /Our-People/CAB-Daniel-Danson  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Our-People/BCA  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Our-People/ABC-Steve-Johnson  [BDO.Person]
│   │   ├── /Our-People/Tadas-Lape  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget, BDO.Widget.Accordion, BDO.Widget.FlexibleContent
│   │   ├── /Our-People/Vardenis-Pavardenis  [BDO.Person]
│   │   ├── /Our-People/Vardas-Pavarde  [BDO.Person]
│   │   ├── /Our-People/Freya-Bates  [BDO.Person]
│   │   ├── /Our-People/Nicole-Potts  [BDO.Person]
│   │   ├── /Our-People/Henry-Parkes  [BDO.Person]
│   │   ├── /Our-People/George-Edwards  [BDO.Person]
│   │   │   └── Widgets: Kentico.FormWidget
│   │   ├── /Our-People/Juanita-House  [BDO.Person]
│   │   ├── /Our-People/Tommy-Ragsdale  [BDO.Person]
│   │   ├── /Our-People/Executive-director  [BDO.Person]
│   │   ├── /Our-People/Person-2  [BDO.Person]
│   │   └── /Our-People/Person1  [BDO.Person]
│   ├── /RSS  [BDO.SectionRss]
│   │   ├── /RSS/News-RSS  [BDO.Rss]
│   │   ├── /RSS/Deals  [BDO.Rss]
│   │   ├── /RSS/Insights-RSS  [BDO.Rss]
│   │   └── /RSS/Test-page  [BDO.ThankYouConversionPage]
│   ├── /Careers  [BDO.SectionCareers]
│   │   └── Widgets: BDO.Widget.RichText, BDO.Widget.HTML, BDO.Widget.FlexibleBanner, BDO.Widget.Button, BDO.Widget.EventsWebinarsSlider, BDO.Widget.Accordion, BDO.Widget.QuoteCard, BDO.Widget.TabAccordion
│   │   ├── /Careers/Test-Search  [BDO.Careers]
│   │   │   ├── /Careers/Test-Search/career-2  [BDO.Career]
│   │   │   ├── /Careers/Test-Search/test-career  [BDO.Career]
│   │   │   ├── /Careers/Test-Search/Testing-API-EV1-title  [BDO.Career]
│   │   │   └── /Careers/Test-Search/Test-option  [BDO.Career]
│   │   │       └── Widgets: BDO.Widget.RichText
│   │   ├── /Careers/Job-Opportunities  [BDO.Careers]
│   │   │   ├── /Careers/Job-Opportunities/Mesijas  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/QA-Tester  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Junior-Accountant,-Canadian-Tax-Services  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Return-to-selected-search-result-Senior-Accountant  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Senior-Accountant,-Domestic-Tax  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Senior-Administrative-Assistant  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Experienced-Senior-Associate,-Private-Client-Servi  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Tax-Senior,-Transaction-Advisory-Services  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Experienced-Audit-Senior  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Healthcare-Rev-Cycle-Sr-Mgr  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Global-Mobility-Tax-Manager  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Assurance-Associate  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/STS-Transfer-Pricing-Associate  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/International-Tax-Intern  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/JAVA-DEVELOPER  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/MS-POWER-PLATFORM-DEVELOPER  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/SR-QA-TESTER  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/SCRUM-MASTER  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/International-Tax-Manager  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/Senior-Manager,-Assurance  [BDO.Career]
│   │   │   ├── /Careers/Job-Opportunities/OPERATIONS-MANAGER-AND-SERVICE-MANAGER  [BDO.Career]
│   │   │   └── /Careers/Job-Opportunities/NET-SOFTWARE-DEVELOPER-(FULL-STACK)  [BDO.Career]
│   │   └── /Careers/Career-Category-Internships  [BDO.CareerCategory]
│   │       └── Widgets: BDO.Widget.FlexibleBanner
│   │       └── /Careers/Career-Category-Internships/Career-Content-QA-Internship  [BDO.CareerContent]
│   │           └── Widgets: BDO.Widget.EventsWebinarsSlider, BDO.Widget.Button
│   │           └── /Careers/Career-Category-Internships/Career-Content-QA-Internship/Career-Content  [BDO.CareerContent]
│   ├── /Sitemap  [BDO.Sitemap]
│   └── /Navigation  [BDO.Navigation]
│       ├── /Navigation/Deals  [BDO.NavigationFirstLevelItem]
│       ├── /Navigation/In-Focus  [BDO.NavigationFirstLevelItem]
│       ├── /Navigation/Industries-(1)  [BDO.NavigationFirstLevelItem]
│       │   ├── /Navigation/Industries-(1)/Navigation-Featured-2  [BDO.NavigationFeaturedItem]
│       │   ├── /Navigation/Industries-(1)/Navigation-Featured  [BDO.NavigationFeaturedItem]
│       │   ├── /Navigation/Industries-(1)/Grow-Your-Business  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries-(1)/Evolve-Your-Operation  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries-(1)/Das-Hinweisgeberschutzgesetz-Ist-Da!  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries-(1)/PRASENSVERANSTALTUNG23s  [BDO.NavigationSecondLevelItem]
│       │   └── /Navigation/Industries-(1)/Comply-with-Regulations  [BDO.NavigationSecondLevelItem]
│       ├── /Navigation/Services  [BDO.NavigationFirstLevelItem]
│       │   ├── /Navigation/Services/Insight-1  [BDO.NavigationSecondLevelItem]
│       │   │   └── Linked -> /Navigation/Insights/Insight-1 [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Services/service-test  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Services/Featured-content  [BDO.NavigationFeaturedItem]
│       │   ├── /Navigation/Services/BDO-Digital  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Services/Test-font  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Services/Tax  [BDO.NavigationSecondLevelItem]
│       │   │   └── /Navigation/Services/Tax/Indirect-Tax  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Services/Test  [BDO.NavigationSecondLevelItem]
│       │   │   └── /Navigation/Services/Test/Deal-card  [BDO.NavigationThirdLevelItem]
│       │   └── /Navigation/Services/Business-Line  [BDO.NavigationSecondLevelItem]
│       ├── /Navigation/Industries  [BDO.NavigationFirstLevelItem]
│       │   ├── /Navigation/Industries/Aerospace  [BDO.NavigationFeaturedItem]
│       │   ├── /Navigation/Industries/Financial-Services  [BDO.NavigationSecondLevelItem]
│       │   │   └── /Navigation/Industries/Financial-Services/Industry  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Industries/Consumer-Services  [BDO.NavigationSecondLevelItem]
│       │   │   ├── /Navigation/Industries/Consumer-Services/Food  [BDO.NavigationThirdLevelItem]
│       │   │   └── /Navigation/Industries/Consumer-Services/Delivery-Services  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Industries/Automotive  [BDO.NavigationSecondLevelItem]
│       │   │   └── /Navigation/Industries/Automotive/Industry  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Industries/Natural-Resources-and-Energy  [BDO.NavigationSecondLevelItem]
│       │   │   ├── /Navigation/Industries/Natural-Resources-and-Energy/Mining  [BDO.NavigationThirdLevelItem]
│       │   │   ├── /Navigation/Industries/Natural-Resources-and-Energy/Oil-Gas  [BDO.NavigationThirdLevelItem]
│       │   │   ├── /Navigation/Industries/Natural-Resources-and-Energy/Renewable-Energy  [BDO.NavigationThirdLevelItem]
│       │   │   └── /Navigation/Industries/Natural-Resources-and-Energy/The-Near-Future-of  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Industries/Real-Estate-and-Construction  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Private-Equity  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Technology,-media-entertainment,-telecommunication  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Public-Sector  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Healthcare  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Manufacturing  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Professional-Services  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/Industries/Not-for-Profit  [BDO.NavigationSecondLevelItem]
│       │   └── /Navigation/Industries/Shipping-and-Transport  [BDO.NavigationSecondLevelItem]
│       ├── /Navigation/Insights  [BDO.NavigationFirstLevelItem]
│       │   ├── /Navigation/Insights/Insight-1  [BDO.NavigationSecondLevelItem]
│       │   │   └── /Navigation/Insights/Insight-1/Insight-2  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Insights/Blogs  [BDO.NavigationSecondLevelItem]
│       │   │   ├── /Navigation/Insights/Blogs/Tech-and-media  [BDO.NavigationThirdLevelItem]
│       │   │   ├── /Navigation/Insights/Blogs/Blog  [BDO.NavigationThirdLevelItem]
│       │   │   ├── /Navigation/Insights/Blogs/Female-entrepreneurs-discuss-woman-in-technology  [BDO.NavigationThirdLevelItem]
│       │   │   └── /Navigation/Insights/Blogs/Five-trends-defining-TMT-companies-reward  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Insights/Webinars-On-demand  [BDO.NavigationSecondLevelItem]
│       │   │   ├── /Navigation/Insights/Webinars-On-demand/Events  [BDO.NavigationThirdLevelItem]
│       │   │   ├── /Navigation/Insights/Webinars-On-demand/On-demand-and-recordings  [BDO.NavigationThirdLevelItem]
│       │   │   └── /Navigation/Insights/Webinars-On-demand/Webinars  [BDO.NavigationThirdLevelItem]
│       │   ├── /Navigation/Insights/EV-Featured-Test-2  [BDO.NavigationFeaturedItem]
│       │   ├── /Navigation/Insights/Test-featured  [BDO.NavigationFeaturedItem]
│       │   └── /Navigation/Insights/Microsites  [BDO.NavigationSecondLevelItem]
│       │       ├── /Navigation/Insights/Microsites/1-page  [BDO.NavigationThirdLevelItem]
│       │       ├── /Navigation/Insights/Microsites/2-page  [BDO.NavigationThirdLevelItem]
│       │       └── /Navigation/Insights/Microsites/3-page  [BDO.NavigationThirdLevelItem]
│       ├── /Navigation/About-Us  [BDO.NavigationFirstLevelItem]
│       │   ├── /Navigation/About-Us/People  [BDO.NavigationFeaturedItem]
│       │   ├── /Navigation/About-Us/About-the-people  [BDO.NavigationSecondLevelItem]
│       │   ├── /Navigation/About-Us/About  [BDO.NavigationSecondLevelItem]
│       │   └── /Navigation/About-Us/Global-Network  [BDO.NavigationSecondLevelItem]
│       └── /Navigation/Accessibility  [BDO.NavigationFirstLevelItem]
└── /Reusable-Content-Tab/Abc/Services  [CMS.Folder]
```

> **Cultures:** ar-DZ, nl-NL, en-AU, en-GB, fi-FI, ka-GE, he-IL, ko-KR, lt-LT, nb-NO, nn-NO — tree structure is identical across cultures.

- **Total pages:** 808
- **Page types in use:** 92
- **Linked pages:** 6
- **Cultures:** ar-DZ, nl-NL, en-AU, en-GB, fi-FI, ka-GE, he-IL, ko-KR, lt-LT, nb-NO, nn-NO

#### Linked Pages

| Linked Page | Linked Class | Original Page | Original Class |
| ----------- | ------------ | ------------- | -------------- |
| /Blogs/BDO-Healthcare/Contributors/Person1 | BDO.Person | /Our-People/Person1 | BDO.Person |
| /Blogs/RK-Blog/Contributors/Bio-page | BDO.Person | /Our-People/Bio-page | BDO.Person |
| /Blogs/Tech-Media-Watch-Blog/Contributors/Juanita-House | BDO.Person | /Our-People/Juanita-House | BDO.Person |
| /Deals/MV-Deal-3-(2) | BDO.Deal | /Deals/MV-Deal-3 | BDO.Deal |
| /Insights/מיסים/Julegave-fra-arbeidsgiver-skattefritt-eller-skatte | BDO.Insight | /Insights/IT-Compliance/Julegave-fra-arbeidsgiver-skattefritt-eller-skatte | BDO.Insight |
| /Navigation/Services/Insight-1 | BDO.NavigationSecondLevelItem | /Navigation/Insights/Insight-1 | BDO.NavigationSecondLevelItem |

### Integrations

```text
/  [CMS.Root]
├── /Section-Widget-Content  [BDO.SectionWidgetContent]
├── /Insights  [BDO.SectionInsightsPage]
│   └── /Insights/After-change-test  [BDO.Insight]
├── /Deal-From-Integrations-For-demo  [BDO.SectionDeals]
│   ├── /Deal-From-Integrations-For-demo/Lape-Integrations-Deal  [BDO.Deal]
│   ├── /Deal-From-Integrations-For-demo/Deal-Test-from-Integration  [BDO.Deal]
│   └── /Deal-From-Integrations-For-demo/Deal-From-Integrations-For-demo  [BDO.Deal]
├── /Home2  [BDO.HomePage]
│   └── Widgets: BDO.Widget.HTML
├── /Home  [BDO.HomePage]
│   └── Widgets: BDO.Widget.HTML
├── /Locations  [BDO.Locations]
│   └── /Locations/Location-1  [BDO.LocationCity]
│       └── /Locations/Location-1/Office-1  [BDO.LocationOffice]
├── /People  [BDO.SectionPeoplePage]
│   └── /People/Person-For-testing  [BDO.Person]
└── /Careers  [BDO.SectionCareers]
    └── /Careers/Search  [BDO.Careers]
```

> **Cultures:** nl-NL, en-GB — tree structure is identical across cultures.

- **Total pages:** 17
- **Page types in use:** 14
- **Linked pages:** 0
- **Cultures:** nl-NL, en-GB

### www.bdowow.com

```text
├── /Section-Widget-Content  [BDO.SectionWidgetContent]
├── /Services  [BDO.SectionServices]
├── /Search  [BDO.Search]
└── /Homepage  [BDO.HomePage]
    └── Widgets: BDO.Widget.InsightCarousel
    └── /Homepage/Hero-slide-1  [BDO.HomeHeroSlide]
```

> **Cultures:** en-GB, lt-LT — tree structure is identical across cultures.

- **Total pages:** 5
- **Page types in use:** 5
- **Linked pages:** 0
- **Cultures:** en-GB, lt-LT

### www.bdowow.global

```text
/  [CMS.Root]
├── /Section-Widget-Content  [BDO.SectionWidgetContent]
├── /Deals  [BDO.SectionDeals]
│   └── /Deals/Lape-BDO-WOW-Deal  [BDO.Deal]
├── /Services  [BDO.SectionServices]
├── /Search  [BDO.Search]
└── /Homepage  [BDO.HomePage]
    └── Widgets: BDO.Widget.InsightCarousel
    └── /Homepage/Hero-slide-1  [BDO.HomeHeroSlide]
```

> **Cultures:** en-GB, lt-LT — tree structure is identical across cultures.

- **Total pages:** 8
- **Page types in use:** 8
- **Linked pages:** 0
- **Cultures:** en-GB, lt-LT

---

## Page Types

### BDO.AboutPage — _About Page_

- **Class ID:** 5537
- **Coupled table:** `Bdo_AboutPage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /About-Us/* (10 pages), /Accessibility/About, /About/JJ-About-Widgets, /Section-about/about-page

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | AboutPageID | AboutPageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Blog — _Blog_

- **Class ID:** 5616
- **Coupled table:** `BDO_Blog`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.ContentSectionPage`
- **Used at:** /Blogs/* (9 pages), /Section-blogs/Section-blogs, /Section-Blog/Blog-group

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BlogID | BlogID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ItemListTitle | Item list title | text(200) | No | TextBoxControl | — |
| 18 | ItemListDescription | Item list description | text(200) | No | TextBoxControl | — |
| 19 | ItemListFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 20 | BlogPostListFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 21 | BlogPostListFeaturedItems | Featured blogs posts | text(200) | No | Uni_selector |  → cms.document.bdo.blogpost |
| 22 | ItemListAdvancedSearchDescription | Advanced search description | text(200) | No | TextBoxControl | — |
| 23 | ItemListAdvancedSearchLinkText | Advanced search link text | text(200) | No | TextBoxControl | — |
| 24 | ItemListAdvancedSearchLinkUrl | Advanced search link URL | text(200) | No | URLSelector | — |
| 25 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 26 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 27 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 28 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 29 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 30 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 31 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 32 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.ContentSectionPage`.

### BDO.BlogContributors — _Blog Contributors_

- **Class ID:** 5613
- **Coupled table:** `BDO_BlogContributors`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Blogs/* (4 pages), /Section-blogs/Section-blogs/blog-contributor, /Section-Blog/Blog-group/contributors

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BlogContributorsID | BlogContributorsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | PeopleListDefaultOrder | Default order | text(200) | No | RadioButtonsControl | — |
| 18 | ShowAuthoredInsights | Show authored blogs | boolean | No | CheckBoxControl | — |
| 19 | AuthoredInsightsTitle | Title | text(200) | No | TextBoxControl | — |
| 20 | AuthoredInsightsDescription | Description | text(2000) | No | TextBoxControl | — |
| 21 | AuthoredInsightsBackgroundImageUrl | Background image | text(200) | No | MediaSelectionControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.BlogPost — _Blog Post_

- **Class ID:** 5612
- **Coupled table:** `BDO_BlogPost`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.ContentPage`
- **Used at:** /Blogs/* (12 pages), /Section-blogs/Section-blogs/Blog-post-group/Blog-post, /Section-Blog/Blog-group/Blog-post-group/Blog-post

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BlogPostID | BlogPostID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | ShowTitle | Show title | boolean | No | CheckBoxControl | — |
| 4 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 5 | ShowDescription | Show description | boolean | No | CheckBoxControl | — |
| 6 | Content | Content | longtext | No | HtmlAreaControl | — |
| 7 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 8 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 9 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 10 | UpdatedOn | Updated on | datetime | No | CalendarControl | — |
| 11 | ShowSidebar | Show sidebar | boolean | No | CheckBoxControl | — |
| 12 | ShowPrintButton | Show print button | boolean | No | CheckBoxControl | — |
| 13 | DownloadButtonAttachment | Download button attachment | text(200) | No | MediaSelectionControl | — |
| 14 | ShowSocialMediaButtons | Show social media buttons | boolean | No | CheckBoxControl | — |
| 15 | ShowCallToAction | Show call to action | boolean | No | CheckBoxControl | — |
| 16 | CallToActionDescription | Call to action description | text(200) | No | TextBoxControl | — |
| 17 | CallToActionButtonText | Call to action button text | text(50) | No | TextBoxControl | — |
| 18 | CallToActionButtonUrl | Call to action button URL | text(200) | No | URLSelector | — |
| 19 | Image | Image | text(250) | No | MediaSelectionControl | — |
| 20 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 21 | ContentType | Type | text(1000) | No | MultiSelector | — |
| 22 | MetadataRssCategory | RSS category | text(200) | No | MultiSelector | — |
| 23 | MetadataRssImage | RSS Image | text(200) | No | MediaSelectionControl | — |
| 24 | RelevantContactPerson | Relevant contact people | text(1000) | No | MultiSelector | — |
| 25 | PeopleSort | People sort | longtext | No | BDO.InsightPeopleSort | — |
| 26 | RelatedExternalPeople | Related external people | text(1000) | No | MultiSelector | — |
| 27 | MetadataKeywords | Keywords | longtext | No | TextBoxControl | — |
| 28 | MetadataBusinessIssues | Business Issue | text(200) | No | MultiSelector | — |
| 29 | MetadataIndustryCategories | Industry Category | text(200) | No | MultiSelector | — |
| 30 | MetadataIndustries | Industries | text(200) | No | MultiSelector | — |
| 31 | MetadataBusinessLines | Business lines | text(200) | No | MultiSelector | — |
| 32 | MetadataServiceAreas | Service areas | text(200) | No | MultiSelector | — |
| 33 | MetadataServices | Services | text(200) | No | MultiSelector | — |
| 34 | MicrositeMasterPages | Microsite master pages | text(200) | No | MultiSelector | — |
| 35 | MicrositePages | Microsite pages | text(200) | No | MultiSelector | — |
| 36 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 37 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 38 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 39 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 40 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 41 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 42 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 43 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.ContentPage`.

### BDO.BlogPostGroup — _Blog Post Group_

- **Class ID:** 5615
- **Coupled table:** `BDO_BlogPostGroup`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Blogs/* (9 pages), /Section-blogs/Section-blogs/Blog-post-group, /Section-Blog/Blog-group/Blog-post-group

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BlogPostGroupID | BlogPostGroupID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.BusinessLine — _Business line_

- **Class ID:** 5532
- **Coupled table:** `BDO_BusinessLine`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /საქართველოში/* (14 pages), /Advisory/Advisory, /Advisory/BDO-Consulting, /Advisory/MV-Bussiness-line, /Section-Services/Advisory, /Services/Business-line

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BusinessLineID | BusinessLineID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | TileIcon | Tile icon | file | No | DirectUploadControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 9 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 10 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 11 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 12 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 13 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 14 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 15 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 16 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 17 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 18 | ContentTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | ContentBody | Content | longtext | No | HtmlAreaControl | — |
| 20 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 21 | SideNavigationTitle | Title | text(200) | No | TextBoxControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.BusinessStrategiesCategory — _Business Strategies Category_

- **Class ID:** 5680
- **Coupled table:** `BDO_BusinessStrategiesCategory`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Business-Strategies/Business-Strategy-Category, /Business-Strategies/Category-2

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BusinessStrategiesCategoryID | BusinessStrategiesCategoryID | integer | No | — | — |
| 2 | Name | Name | text(200) | No | TextBoxControl | — |

### BDO.BusinessStrategy — _Business Strategy_

- **Class ID:** 5681
- **Coupled table:** `BDO_BusinessStrategy`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Business-Strategies/* (11 pages), /Business-strategies/Business-Strategy

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BusinessStrategyID | BusinessStrategyID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MenuShowInSection | Show in section menu | boolean | No | CheckBoxControl | — |
| 18 | MenuReadMoreText | Read more text | text(200) | No | TextBoxControl | — |
| 19 | MenuTileIcon | Tile icon | file | No | DirectUploadControl | — |
| 20 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 21 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 22 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 24 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 26 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 27 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Career — _Career Job Opportunity_

- **Class ID:** 5559
- **Coupled table:** `BDO_Career`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Careers/* (32 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerID | CareerID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ShowSidebar | Show sidebar | boolean | No | CheckBoxControl | — |
| 18 | ShowPrintButton | Show print button | boolean | No | CheckBoxControl | — |
| 19 | DownloadButtonAttachment | Download button attachment | text(200) | No | MediaSelectionControl | — |
| 20 | ShowCallToAction | Show call to action | boolean | No | CheckBoxControl | — |
| 21 | CallToActionDescription | Call to action description | text(200) | No | TextBoxControl | — |
| 22 | CallToActionButtonText | Call to action button text | text(50) | No | TextBoxControl | — |
| 23 | CallToActionButtonUrl | Call to action button URL | text(200) | No | URLSelector | — |
| 24 | ShowSocialMediaButtons | Show social media buttons | boolean | No | CheckBoxControl | — |
| 25 | DocumentPublishFrom | Publish date | datetime | No | CalendarControl | — |
| 26 | DocumentPublishTo | Publish to | datetime | No | CalendarControl | — |
| 27 | CareerContactPeopleID | Contact person | integer | No | DropDownListControl | — |
| 28 | MetadataRelevantContactPerson | Relevant contact people | text(1000) | No | MultiSelector | — |
| 29 | MetadataOfficeLocation | Work locations | text(200) | No | MultiSelector | — |
| 30 | CareerReference | Reference | text(30) | No | TextBoxControl | — |
| 31 | CareerJobTitle | Job title | integer | No | Uni_selector |  → BDOMetadata.CareerJobTitle |
| 32 | CareerLevel | Level | integer | No | Uni_selector |  → BDOMetadata.CareerLevel |
| 33 | CareerEmploymentType | Employment type | integer | No | Uni_selector |  → BDOMetadata.CareerEmploymentType |
| 34 | CareerApplyForm | Form | text(200) | No | ObjectSelector |  → cms.form |
| 35 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 36 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 37 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 38 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 39 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 40 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 41 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 42 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.CareerCategory — _Career Category_

- **Class ID:** 5561
- **Coupled table:** `BDO_CareerCategory`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Careers/Junior-Specialists, /Careers/Junior-QA, /Careers/Career-Category-Internships

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerCategoryID | CareerCategoryID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.CareerContent — _Career Content_

- **Class ID:** 5560
- **Coupled table:** `BDO_CareerContent`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Careers/Career-Category-Internships/Career-Content-QA-Internship, /Careers/Career-Category-Internships/Career-Content-QA-Internship/Career-Content

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerContentID | CareerContentID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Careers — _Career Job Opportunities_

- **Class ID:** 5651
- **Coupled table:** `BDO_Careers`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Careers/* (5 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareersID | CareersID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ItemListTitle | Item list title | text(200) | No | TextBoxControl | — |
| 18 | ItemListDescription | Item list description | text(200) | No | TextBoxControl | — |
| 19 | ItemListFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 20 | CareerListFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 21 | ItemListAdvancedSearchDescription | Advanced search description | text(200) | No | TextBoxControl | — |
| 22 | ItemListAdvancedSearchLinkText | Advanced search link text | text(200) | No | TextBoxControl | — |
| 23 | ItemListAdvancedSearchLinkUrl | Advanced search link URL | text(200) | No | URLSelector | — |
| 24 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 25 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 26 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 28 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 29 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 30 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 31 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Contact — _Contact_

- **Class ID:** 5521
- **Coupled table:** `BDO_Contact`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Blogs/Tech-Media-Watch-Blog/Contact-Us, /Blogs/IT-Blogs/Title, /Contact-us, /Contact-page, /Contact, /Subscribe-to-BDO-News, /Contact-Us

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ContactID | ContactID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | DescriptionTitle | Title | text(200) | No | TextBoxControl | — |
| 18 | DescriptionBody | Body content | longtext | No | HtmlAreaControl | — |
| 19 | FormType | Type | text(200) | No | RadioButtonsControl | — |
| 20 | Form | Form | text(200) | No | DropDownListControl | — |
| 21 | EmbedCode | Embed Code | text(1000) | No | TextAreaControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Deal — _Deal_

- **Class ID:** 5544
- **Coupled table:** `BDO_Deal`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Deals/* (34 pages), /Deal-From-Integrations-For-demo/Deal-From-Integrations-For-demo, /Deal-From-Integrations-For-demo/Deal-Test-from-Integration, /Deal-From-Integrations-For-demo/Lape-Integrations-Deal, /Section-Deals/Deal-page

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | DealID | DealID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | ShowTitle | Show title | boolean | No | CheckBoxControl | — |
| 4 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 5 | DealContent | Content | longtext | No | HtmlAreaControl | — |
| 6 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 7 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 8 | Industry | Industry | text(1000) | No | TextBoxControl | — |
| 9 | SubIndustry | Sub Industry | text(1000) | No | TextBoxControl | — |
| 10 | IndustriesSelector | Industry~Sub-industry | text(1000) | No | BDO.IndustrySelector | — |
| 11 | DealType | Deal type | text(1000) | No | MultiSelector | — |
| 12 | DateField | Date | date | No | CalendarControl | — |
| 13 | Size | Deal size | text(200) | No | DropDownListControl | — |
| 14 | MetadataOfficeLocation | Office location | text(200) | No | MultiSelector | — |
| 15 | ClientName | Client name | text(99) | No | TextBoxControl | — |
| 16 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 17 | RelatedDeals | Related deals | text(200) | No | MultiSelector | — |
| 18 | MetadataRssCategory | RSS category | text(200) | No | MultiSelector | — |
| 19 | MetadataRssImage | RSS image | text(200) | No | MediaSelectionControl | — |
| 20 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 21 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 22 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 23 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 24 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 25 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 26 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 27 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 28 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 29 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 30 | ShowSidebar | Show sidebar | boolean | No | CheckBoxControl | — |
| 31 | ShowPrintButton | Show print button | boolean | No | CheckBoxControl | — |
| 32 | DownloadButtonAttachment | Download button attachment | text(200) | No | MediaSelectionControl | — |
| 33 | ShowCallToAction | Show call to action | boolean | No | CheckBoxControl | — |
| 34 | CallToActionDescription | Call to action description | text(200) | No | TextBoxControl | — |
| 35 | CallToActionButtonText | Call to action button text | text(50) | No | TextBoxControl | — |
| 36 | CallToActionButtonUrl | Call to action button URL | text(200) | No | URLSelector | — |
| 37 | ShowSocialMediaButtons | Show social media buttons | boolean | No | CheckBoxControl | — |
| 38 | SharingOptIn | Share deal on BDO Global website | boolean | No | CheckBoxControl | — |
| 39 | DealCountry | Country | text(200) | No | TextBoxControl | — |
| 40 | DisplayedContacts | No. of contacts displayed in sidebar | integer | No | DropDownListControl | — |
| 41 | RelevantContactPerson | Relevant contact people | text(200) | No | MultiSelector | — |
| 42 | PeopleSort | Sort people | longtext | No | BDO.InsightPeopleSort | — |
| 43 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 44 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 45 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 46 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 47 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 48 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 49 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 50 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.DealFolder — _Deal Folder_

- **Class ID:** 5700
- **Coupled table:** — _(no custom data table, all data lives in CMS_Tree/CMS_Document)_
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Deals/Lape-Deals, /Deals/Example-Deal-Folder, /Deals/JJ-Deal-(1)

*No custom fields.*

### BDO.Event — _Event_

- **Class ID:** 5519
- **Coupled table:** `BDO_Event`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.EventBase`
- **Used at:** /Events/* (45 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | EventID | EventID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | ShowTitle | Show title | boolean | No | CheckBoxControl | — |
| 4 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 5 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 6 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | EventPostDescription | Post event description | text(800) | No | TextAreaControl | — |
| 9 | CustomBodyText | Calendar custom body text | longtext | No | HtmlAreaControl | — |
| 10 | EventDateFrom | Date from | datetime | No | CalendarControl | — |
| 11 | EventDateTo | Date to | datetime | No | CalendarControl | — |
| 12 | EventTimeOverride | Time text override | text(100) | No | TextBoxControl | — |
| 13 | EventDateOverride | Date text Override | text(200) | No | TextBoxControl | — |
| 14 | EventIsPrivate | Is This Event Private | boolean | No | CheckBoxControl | — |
| 15 | EventAllDay | All-day event | boolean | No | CheckBoxControl | — |
| 16 | AllowRegistration | You can register for this event | boolean | No | CheckBoxControl | — |
| 17 | EventType | Type | text(200) | No | MultiSelector | — |
| 18 | DisablePrintAndShare | Disable print and share | boolean | No | CheckBoxControl | — |
| 19 | DisableAddToCalendar | Disable 'Add to calendar' | boolean | No | CheckBoxControl | — |
| 20 | ShowPastEvent | Show past event | boolean | No | CheckBoxControl | — |
| 21 | RegistrationType | Registration type | text(200) | No | DropDownListControl | — |
| 22 | RegistrationFormLink | Registration form link | text(2000) | No | URLSelector | — |
| 23 | CpeEvent | Continuing professional education event | boolean | No | CheckBoxControl | — |
| 24 | ProgramLevel | Program level | text(200) | No | DropDownListControl | — |
| 25 | CpeCount | CPE Count | text(50) | No | TextBoxControl | — |
| 26 | CpeCreditNotes | CPE Credit Notes | text(100) | No | TextBoxControl | — |
| 27 | CpeDescription | CPE Description | longtext | No | HtmlAreaControl | — |
| 28 | EventAttachment | Attachment  | text(200) | No | MediaSelectionControl | — |
| 29 | EventVideo | Video | longtext | No | TextBoxControl | — |
| 30 | MetadataBusinessIssues | Business issue | text(200) | No | MultiSelector | — |
| 31 | MetadataIndustries | Industries | text(200) | No | MultiSelector | — |
| 32 | MetadataIndustryCategories | Industry categories | text(200) | No | MultiSelector | — |
| 33 | MetadataServices | Services | text(200) | No | MultiSelector | — |
| 34 | MetadataBusinessLines | Business lines | text(200) | No | MultiSelector | — |
| 35 | MetadataServiceAreas | Service areas | text(200) | No | MultiSelector | — |
| 36 | MetadataOfficeLocation | Office location | text(200) | No | MultiSelector | — |
| 37 | MetadataSpecialtiesCategories | Specialty categories | text(200) | No | MultiSelector | — |
| 38 | MetadataSpecialtiesAreas | Specialties areas | text(200) | No | MultiSelector | — |
| 39 | MetadataSpecialtiesPages | Specialty pages | text(200) | No | MultiSelector | — |
| 40 | MicrositeMasterPages | Microsite master pages | text(200) | No | MultiSelector | — |
| 41 | MicrositePages | Microsite pages | text(200) | No | MultiSelector | — |
| 42 | MetadataRssCategory | RSS category | text(200) | No | MultiSelector | — |
| 43 | MetadataRssImage | RSS image | text(200) | No | MediaSelectionControl | — |
| 44 | EventLocationTitle | Location title | text(200) | No | TextBoxControl | — |
| 45 | EventLocationAddress1 | Location address | text(256) | No | TextBoxControl | — |
| 46 | EventLocationAddress2 | Location address 2 | text(256) | No | TextBoxControl | — |
| 47 | EventLocationCity | City | text(1000) | No | TextBoxControl | — |
| 48 | EventLocationState | City/state | text(200) | No | TextBoxControl | — |
| 49 | EventLocationZip | Location ZIP code | text(200) | No | TextBoxControl | — |
| 50 | EventLocationZipPosition | Zip/postal code before or after | text(100) | No | RadioButtonsControl | — |
| 51 | HideEventLocationZipComma | Hide event location Zip/postal code comma | boolean | No | CheckBoxControl | — |
| 52 | EventLocationCountry | Country | text(200) | No | TextBoxControl | — |
| 53 | ShowEventLocation | Show event location by coordinates | boolean | No | CheckBoxControl | — |
| 54 | EventLocationLongitude | Longitude | text(200) | No | TextBoxControl | — |
| 55 | EventLocationLatitude | Latitude | text(200) | No | TextBoxControl | — |
| 56 | EventContactName | Contact name | text(200) | No | TextBoxControl | — |
| 57 | EventContactPhone | Office phone number | text(200) | No | TextBoxControl | — |
| 58 | EventContactEmail | E-mail | text(200) | No | TextBoxControl | — |
| 59 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 60 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 61 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 62 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 63 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 64 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 65 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 66 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.EventBase`.

### BDO.EventRegistrationForm — _Event registration form_

- **Class ID:** 5625
- **Coupled table:** `BDO_EventRegistrationForm`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Events/* (67 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | EventRegistrationFormID | EventRegistrationFormID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | FormType | Type | text(200) | No | RadioButtonsControl | — |
| 18 | Form | Registration form | text(200) | No | DropDownListControl | — |
| 19 | EmbedCode | Embed Code | longtext | No | TextAreaControl | — |
| 20 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 21 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 22 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 24 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 26 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 27 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.EventWebinarFolder — _EventWebinar folder_

- **Class ID:** 5640
- **Coupled table:** — _(no custom data table, all data lives in CMS_Tree/CMS_Document)_
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Events/JJ-Events

*No custom fields.*

### BDO.ExternalPeopleFolder — _External Contributors Folder_

- **Class ID:** 5706
- **Coupled table:** — _(no custom data table, all data lives in CMS_Tree/CMS_Document)_
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /External-People/* (4 pages)

*No custom fields.*

### BDO.ExternalPerson — _External Contributor_

- **Class ID:** 5705
- **Coupled table:** `BDO_ExternalPerson`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /External-People/* (9 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ExternalPersonID | ExternalPersonID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | FirstName | First name | text(200) | No | TextBoxControl | — |
| 4 | SurnamePrefixes | Surname prefixes | text(200) | No | TextBoxControl | — |
| 5 | LastName | Last name | text(200) | No | TextBoxControl | — |
| 6 | Image | Image | text(200) | No | MediaSelectionControl | — |
| 7 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 8 | JobTitle | Job title | text(200) | No | TextBoxControl | — |
| 9 | Url | URL | text(2083) | No | URLSelector | — |

### BDO.FaqFolder — _FAQ Folder_

- **Class ID:** 5765
- **Coupled table:** `BDO_FAQFolder`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Section-Widget-Content/FAQ-Folder, /Section-Widget-Content/FAQ

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | FAQFolderID | FAQFolderID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.FaqPage — _FAQ Page_

- **Class ID:** 5769
- **Coupled table:** `BDO_FaqPage`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Section-Widget-Content/* (11 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | FaqPageID | FaqPageID | integer | No | — | — |
| 2 | Title | Title | text(500) | No | TextBoxControl | — |
| 3 | Question | Question | text(500) | No | TextBoxControl | — |
| 4 | Content | Content | longtext | No | HtmlAreaControl | — |

### BDO.FaqTopic — _FAQ Topic_

- **Class ID:** 5767
- **Coupled table:** `BDO_FAQTopic`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Section-Widget-Content/* (5 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | FAQTopicID | FAQTopicID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.GlobalLocations — _Global Locations_

- **Class ID:** 5601
- **Coupled table:** `BDO_GlobalLocations`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Global-locations, /Global-locations

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GlobalLocationsID | GlobalLocationsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 5 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 6 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 7 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 8 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 9 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 10 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 11 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 13 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 15 | DescriptionTitle | Title | text(200) | No | TextBoxControl | — |
| 16 | DescriptionBody | Body content | longtext | No | HtmlAreaControl | — |
| 17 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

### BDO.HomeHeroSlide — _Home Hero Slide_

- **Class ID:** 5571
- **Coupled table:** `BDO_HomeHeroSlide`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Homepage/* (18 pages), /Home/* (5 pages), /Home-page/Lorem-ipsum-dolor-sit-amet,-consectetur-adipiscing, /Home-page/Curabitur-augue-quam,-feugiat-vel-dolor-quis,-maxi, /Homepage-2/Hero-slide-1

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | HomeHeroSlideID | HomeHeroSlideID | integer | No | — | — |
| 2 | ClarificationText | — | text(1) | No | LabelControl | — |
| 3 | Title | Heading | text(200) | No | TextBoxControl | — |
| 4 | Description | Subheading | text(1000) | No | TextAreaControl | — |
| 5 | CTAButtonText | CTA Button Text | text(200) | No | TextBoxControl | — |
| 6 | CTAButtonUrl | CTA Button URL | text(200) | No | URLSelector | — |
| 7 | Image | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 8 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 9 | Image_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 10 | Image_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 11 | Image_Thumbnail | Thumbnail image | text(200) | No | MediaSelectionControl | — |
| 12 | Image_ThumbnailAltText | Thumbnail image alt text | text(200) | No | TextBoxControl | — |

### BDO.HomePage — _Home Page_

- **Class ID:** 5542
- **Coupled table:** `BDO_HomePage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Homepage/* (4 pages), /Home, /Home, /Home, /Homepage-2, /Home-page, /Home2

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | HomePageID | HomePageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Industry — _Industry_

- **Class ID:** 5530
- **Coupled table:** `BDO_Industry`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Industries/* (13 pages), /Section-indsutries/Финансовыи-сектор/Industry

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | IndustryID | IndustryID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | TileIcon | Tile icon | file | No | DirectUploadControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 9 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 10 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 11 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 12 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 13 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 14 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 15 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 16 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 17 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 18 | DescriptionTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | DescriptionBody | Body content | longtext | No | HtmlAreaControl | — |
| 20 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 21 | SideboxTitle | Sidebox Title | text(200) | No | TextBoxControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.IndustryCategory — _Industry Category_

- **Class ID:** 5531
- **Coupled table:** `BDO_IndustryCategory`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Industries/* (17 pages), /Section-indsutries/Финансовыи-сектор

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | IndustryCategoryID | IndustryCategoryID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | TileIcon | Tile icon | file | No | DirectUploadControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 9 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 10 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 11 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 12 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 13 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 14 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 15 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 16 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 17 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 18 | DescriptionTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | DescriptionBody | Body content | longtext | No | HtmlAreaControl | — |
| 20 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 21 | SideboxTitle | Sidebox Title | text(200) | No | TextBoxControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.IndustryService — _Industry Service_

- **Class ID:** 5528
- **Coupled table:** `BDO_IndustryService`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Industries/* (8 pages), /Section-indsutries/Финансовыи-сектор/Industry/Industry-service

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | IndustryServiceID | IndustryServiceID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | DescriptionTitle | Title | text(200) | No | TextBoxControl | — |
| 18 | DescriptionBody | Body content | longtext | No | HtmlAreaControl | — |
| 19 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 20 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 21 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 23 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 24 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 25 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 26 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.InFocusFolder — _In Focus Folder_

- **Class ID:** 5764
- **Coupled table:** `BDO_InFocusFolder`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Section-Widget-Content/* (4 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InFocusFolderID | InFocusFolderID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.InFocusPage — _In Focus Page_

- **Class ID:** 5766
- **Coupled table:** `BDO_InFocusPage`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Section-Widget-Content/* (8 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InFocusPageID | InFocusPageID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | TitleLink1 | Title | text(200) | No | TextBoxControl | — |
| 4 | SummaryLink1 | Summary | longtext | No | TextAreaControl | — |
| 5 | SelectorLink1 | Link | text(200) | No | URLSelector | — |
| 6 | TextLink1 | Link text | text(200) | No | TextBoxControl | — |
| 7 | NewTabLink1 | Open link in a new tab | boolean | No | CheckBoxControl | — |
| 8 | TitleLink2 | Title | text(200) | No | TextBoxControl | — |
| 9 | SummaryLink2 | Summary | longtext | No | TextAreaControl | — |
| 10 | SelectorLink2 | Link | text(200) | No | URLSelector | — |
| 11 | TextLink2 | Link text | text(200) | No | TextBoxControl | — |
| 12 | NewTabLink2 | Open link in a new tab | boolean | No | CheckBoxControl | — |
| 13 | TitleLink3 | Title | text(200) | No | TextBoxControl | — |
| 14 | SummaryLink3 | Summary | longtext | No | TextAreaControl | — |
| 15 | SelectorLink3 | Link | text(200) | No | URLSelector | — |
| 16 | TextLink3 | Link text | text(200) | No | TextBoxControl | — |
| 17 | NewTabLink3 | Open link in a new tab | boolean | No | CheckBoxControl | — |

### BDO.Insight — _Insight_

- **Class ID:** 5512
- **Coupled table:** `BDO_Insight`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.ContentPage`
- **Used at:** /Insights/* (132 pages), /Section-Insights/Audit/E2E-Insight, /Section-Insights/E2E-Automated-Insight-Category/694863-E2E_Insight, /Section-insights/Insight

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InsightID | InsightID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | ShowTitle | Show title | boolean | No | CheckBoxControl | — |
| 4 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 5 | ShowDescription | Show description | boolean | No | CheckBoxControl | — |
| 6 | Content | Content | longtext | No | HtmlAreaControl | — |
| 7 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 8 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 9 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 10 | DocumentPublishFrom | Publish from | datetime | No | CalendarControl | — |
| 11 | DocumentPublishTo | Publish to | datetime | No | CalendarControl | — |
| 12 | UpdatedOn | Updated on | datetime | No | CalendarControl | — |
| 13 | ShowSidebar | Show sidebar | boolean | No | CheckBoxControl | — |
| 14 | ShowCallToAction | Show call to action | boolean | No | CheckBoxControl | — |
| 15 | CallToActionDescription | Call to action description | text(200) | No | TextBoxControl | — |
| 16 | CallToActionButtonText | Call to action button text | text(50) | No | TextBoxControl | — |
| 17 | CallToActionButtonUrl | Call to action button URL | text(200) | No | URLSelector | — |
| 18 | CallToActionPosition | Call to action position | text(200) | No | RadioButtonsControl | — |
| 19 | ShowPrintButton | Show print button | boolean | No | CheckBoxControl | — |
| 20 | DownloadButtonAttachment | Download button attachment | text(200) | No | MediaSelectionControl | — |
| 21 | ShowSocialMediaButtons | Show social media buttons | boolean | No | CheckBoxControl | — |
| 22 | UseNarrowLayout | Use narrow layout | boolean | No | CheckBoxControl | — |
| 23 | ShowAuthorsAtTheTop | Show authors at the top | boolean | No | CheckBoxControl | — |
| 24 | Image | Image | text(250) | No | MediaSelectionControl | — |
| 25 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 26 | InsightAttachment | Attachment | text(200) | No | MediaSelectionControl | — |
| 27 | DownloadButtonTitle | Download button tooltip | text(200) | No | TextBoxControl | — |
| 28 | DownloadButtonText | Download button text | text(200) | No | TextBoxControl | — |
| 29 | MetadataBusinessIssues | Business Issue | text(200) | No | MultiSelector | — |
| 30 | ContentType | Type | text(1000) | No | MultiSelector | — |
| 31 | MetadataBusinessLines | Business lines | text(200) | No | MultiSelector | — |
| 32 | MetadataServiceAreas | Service areas | text(200) | No | MultiSelector | — |
| 33 | MetadataServices | Services | text(200) | No | MultiSelector | — |
| 34 | MetadataIndustryCategories | Industry categories | text(200) | No | MultiSelector | — |
| 35 | MetadataIndustries | Industries | text(200) | No | MultiSelector | — |
| 36 | MetadataSpecialtiesCategories | Specialties categories | text(200) | No | MultiSelector | — |
| 37 | MetadataSpecialtiesAreas | Specialties areas | text(200) | No | MultiSelector | — |
| 38 | MetadataSpecialtiesPages | Specialty pages | text(200) | No | MultiSelector | — |
| 39 | MetadataOfficeLocation | Office location | text(200) | No | MultiSelector | — |
| 40 | MicrositeMasterPages | Microsite master pages | text(200) | No | MultiSelector | — |
| 41 | MicrositePages | Microsite pages | text(200) | No | MultiSelector | — |
| 42 | MetadataRssCategory | RSS category | text(200) | No | MultiSelector | — |
| 43 | MetadataRssImage | RSS Image | text(200) | No | MediaSelectionControl | — |
| 44 | Insights | Insights | text(2000) | No | MultiSelector | — |
| 45 | RelevantContactPerson | Relevant contact people | text(1000) | No | MultiSelector | — |
| 46 | PeopleSort | People sort | longtext | No | BDO.InsightPeopleSort | — |
| 47 | RelatedExternalPeople | Related external people | text(1000) | No | MultiSelector | — |
| 48 | SharingExplanation | — | text(200) | No | LabelControl | — |
| 49 | SharingOptOut | Disable content sharing for this insight | boolean | No | CheckBoxControl | — |
| 50 | SharingHeadline | Sharing Headline | boolean | No | CheckBoxControl | — |
| 51 | OriginalDocumentAttachmentType | Attachment | text(10) | No | DropDownListControl | — |
| 52 | OriginalIndustries | Industries | text(200) | No | MultiSelector | — |
| 53 | OriginalServiceLines | Business lines | text(200) | No | MultiSelector | — |
| 54 | OriginalInvolvedCountriesAll | For all countries | boolean | No | CheckBoxControl | — |
| 55 | OriginalInvolvedCountries | Involved countries | text(200) | No | MultiSelector | — |
| 56 | OriginalDocumentOwnerOptOut | I don't want to receive notifications when my content is copied | boolean | No | CheckBoxControl | — |
| 57 | OriginalDocumentOwnerName | Creator name | text(200) | No | TextBoxControl | — |
| 58 | OriginalDocumentOwnerEmail | Creator email address | text(200) | No | TextBoxControl | — |
| 59 | DocumentCulture | Language | text(50) | No | LabelControl | — |
| 60 | OriginalSiteGuid | Original Site GUID (source) | guid | No | LabelControl | — |
| 61 | OriginalDocumentGuid | Original Document GUID (source) | guid | No | LabelControl | — |
| 62 | SharingSourceFirm | Insight source country | text(20) | No | DropDownListControl | — |
| 63 | SharingInstructions | Instructions | longtext | No | HtmlAreaControl | — |
| 64 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 65 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 66 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 67 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 68 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 69 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 70 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 71 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.ContentPage`.

### BDO.InsightCategory — _Insight Category_

- **Class ID:** 5526
- **Coupled table:** `BDO_InsightCategory`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Insights/* (18 pages), /Section-Insights/Audit, /Section-Insights/E2E-Automated-Insight-Category

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InsightCategoryID | InsightCategoryID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.InsightGroup — _Insight Group_

- **Class ID:** 5524
- **Coupled table:** `BDO_InsightGroup`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Insights/* (6 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InsightGroupID | InsightGroupID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.InternalPeopleFolder — _Internal Contributors Folder_

- **Class ID:** 5758
- **Coupled table:** — _(no custom data table, all data lives in CMS_Tree/CMS_Document)_
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /External-People/Internal-Contributors, /External-People/Internal-People, /External-People/Internal-People/internal-contributor-folder

*No custom fields.*

### BDO.InternalPerson — _Internal Contributor_

- **Class ID:** 5757
- **Coupled table:** `BDO_InternalPerson`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /External-People/Internal-Contributors/Internal-Contributor, /External-People/Internal-People/Internal-contributor-1, /External-People/Internal-contributor-2

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InternalPersonID | ExternalPersonID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | FirstName | First name | text(200) | No | TextBoxControl | — |
| 4 | SurnamePrefixes | Surname prefixes | text(200) | No | TextBoxControl | — |
| 5 | LastName | Last name | text(200) | No | TextBoxControl | — |
| 6 | Image | Image | text(200) | No | MediaSelectionControl | — |
| 7 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 8 | JobTitle | Job title | text(200) | No | TextBoxControl | — |
| 9 | Email | E-mail | text(200) | No | TextBoxControl | — |
| 10 | Url | URL | text(2083) | No | URLSelector | — |

### BDO.LegalPage — _Legal Page_

- **Class ID:** 5555
- **Coupled table:** `BDO_LegalPage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Legal/Privacy, /Legal/Cookies, /Section-Legal/Cookies, /Section-Legal/Privacy-Policy, /Privacy-policy/Privacy-policy

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | LegalPageID | LegalPageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.LocationCity — _Location City_

- **Class ID:** 5596
- **Coupled table:** `BDO_LocationCity`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Locations/* (11 pages), /locations/location-city

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | LocationCityID | LocationCityID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | RegionName | Full State/Region Name | text(200) | No | DropDownListControl | — |
| 8 | ContentTitle | Content title | text(200) | No | TextBoxControl | — |
| 9 | SectionTitle | Section title | text(200) | No | TextBoxControl | — |
| 10 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 11 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 12 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 13 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 14 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 15 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 16 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 17 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 18 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 19 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 20 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 21 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 22 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 24 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 26 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 27 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.LocationOffice — _Location Office_

- **Class ID:** 5595
- **Coupled table:** `BDO_LocationOffice`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Locations/* (18 pages), /locations/location-city/location-office

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | LocationOfficeID | LocationID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | OfficeImage | Office image | text(200) | No | MediaSelectionControl | — |
| 7 | OfficeImageAltText | Office image alt text | text(200) | No | TextBoxControl | — |
| 8 | LocationAddressLine1 | Address line 1 | text(200) | No | TextBoxControl | — |
| 9 | LocationAddressLine2 | Address line 2 | text(200) | No | TextBoxControl | — |
| 10 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 11 | LocationZip | Postal code | text(200) | No | TextBoxControl | — |
| 12 | LocationZipDisplayType | Display postal code | text(200) | No | RadioButtonsControl | — |
| 13 | LocationCountry | Country | text(200) | No | TextBoxControl | — |
| 14 | LocationLatitude | Latitude | text(200) | No | TextBoxControl | — |
| 15 | LocationLongitude | Longitude | text(200) | No | TextBoxControl | — |
| 16 | LocationEmail | Email | text(200) | No | emailinput | — |
| 17 | LocationType | Location type | integer | No | DropDownListControl | — |
| 18 | LocationPhone | Office phone number | text(20) | No | TextBoxControl | — |
| 19 | LocationFax | Fax | text(20) | No | TextBoxControl | — |
| 20 | OpeningHours | Opening hours | text(200) | No | TextAreaControl | — |
| 21 | LocationPOBoxNumber | PO box number | text(200) | No | TextBoxControl | — |
| 22 | LocationPOCity | City | text(200) | No | TextBoxControl | — |
| 23 | LocationPOZip | Postal code | text(200) | No | TextBoxControl | — |
| 24 | LocationPOZipDisplayType | Display postal code | text(200) | No | RadioButtonsControl | — |
| 25 | LocationPOCountry | Country | text(200) | No | TextBoxControl | — |
| 26 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 27 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 28 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 29 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 30 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 31 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 32 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 33 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Locations — _Locations_

- **Class ID:** 5523
- **Coupled table:** `BDO_Locations`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Locations/* (4 pages), /locations

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | LocationsID | LocationsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | DescriptionTitle | Title | text(200) | No | TextBoxControl | — |
| 18 | DescriptionBody | Body content | longtext | No | HtmlAreaControl | — |
| 19 | LocationsTitle | Title | text(200) | No | TextBoxControl | — |
| 20 | BannerContent | Banner content | longtext | No | HtmlAreaControl | — |
| 21 | BannerBackgroundImage | Image | text(200) | No | URLSelector | — |
| 22 | BannerTheme | Theme | text(200) | No | RadioButtonsControl | — |
| 23 | BannerButtonType | Banner button type | text(200) | No | RadioButtonsControl | — |
| 24 | BannerButtonText | Banner button text | text(200) | No | TextBoxControl | — |
| 25 | BannerButtonURL | Banner button URL | text(200) | No | URLSelector | — |
| 26 | BannerButtonLinkTarget | Banner button link target | text(200) | No | RadioButtonsControl | — |
| 27 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 28 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 29 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 30 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 31 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 32 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 33 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 34 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.MicrositeMasterPage — _Microsite - Master Page_

- **Class ID:** 5592
- **Coupled table:** `BDO_MicrositeMasterPage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Microsites/* (12 pages), /Microsites-staging/Microsite-Master-Page, /Digital/Digital

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | MicrositeMasterPageID | MicrositeID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | SettingsMenuType | Menu type | text(20) | No | DropDownListControl | — |
| 8 | LogoLinkTarget | Logo Link target | text(10) | No | DropDownListControl | — |
| 9 | LogoText | Logo text | text(100) | No | TextBoxControl | — |
| 10 | CustomJS | Head Javascript | docattachments | No | DocumentAttachmentsControl | — |
| 11 | CustomCSS | Head CSS | docattachments | No | DocumentAttachmentsControl | — |
| 12 | HeadHTML | Head HTML | longtext | No | TextAreaControl | — |
| 13 | BodyTopHTML | HTML top of body | longtext | No | TextAreaControl | — |
| 14 | BodyBottomHTML | HTML bottom of body | longtext | No | TextAreaControl | — |
| 15 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 16 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 17 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 18 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 19 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 21 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 22 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.MicrositePage — _Microsite - Page_

- **Class ID:** 5591
- **Coupled table:** `BDO_MicrositePage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Microsites/* (27 pages), /Microsites-staging/* (7 pages), /Digital/* (5 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | MicrositePageID | MicrositePageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MicrositeImage | Image | text(250) | No | MediaSelectionControl | — |
| 8 | MicrositeImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 9 | Homepage | Homepage | text(200) | No | MultiSelector | — |
| 10 | ContentType | Type | text(1000) | No | BDO.ExportableDropdownlist | — |
| 11 | BusinessLines | Business lines | text(200) | No | MultiSelector | — |
| 12 | ServiceAreas | Service areas | text(200) | No | MultiSelector | — |
| 13 | Services | Services | text(200) | No | MultiSelector | — |
| 14 | IndustryCategories | Industry categories | text(200) | No | MultiSelector | — |
| 15 | Industries | Industries | text(200) | No | MultiSelector | — |
| 16 | SpecialitiesCategories | Specialities categories | text(200) | No | MultiSelector | — |
| 17 | SpecialitiesAreas | Specialities areas | text(200) | No | MultiSelector | — |
| 18 | SpecialitiesPages | Speciality pages | text(200) | No | MultiSelector | — |
| 19 | PageHeadHTML | Head HTML | longtext | No | TextAreaControl | — |
| 20 | PageTopBodyHTML | HTML top of body | longtext | No | TextAreaControl | — |
| 21 | PageBottomBodyHTML | HTML bottom of body | longtext | No | TextAreaControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Navigation — _Navigation_

- **Class ID:** 5568
- **Coupled table:** `BDO_Navigation`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Navigation/* (4 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NavigationID | NavigationID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.NavigationFeaturedItem — _Navigation featured item_

- **Class ID:** 5567
- **Coupled table:** `BDO_NavigationFeaturedItem`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Navigation/* (11 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NavigationFeaturedItemID | NavigationFeaturedItemID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | Description | Description | text(200) | No | TextAreaControl | — |
| 4 | TargetURL | URL | text(2048) | No | URLSelector | — |
| 5 | Image | Image | text(2048) | No | MediaSelectionControl | — |
| 6 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |

### BDO.NavigationFirstLevelItem — _Navigation first level item_

- **Class ID:** 5566
- **Coupled table:** `BDO_NavigationFirstLevelItem`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Navigation/* (15 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NavigationFirstLevelItemID | NavigationFirstLevelItemID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | TargetURL | URL | text(2048) | No | URLSelector | — |

### BDO.NavigationSecondLevelItem — _Navigation second level item_

- **Class ID:** 5569
- **Coupled table:** `BDO_NavigationSecondLevelItem`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Navigation/* (40 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NavigationSecondLevelItemID | NavigationSecondLevelItemID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | Description | Description | text(200) | No | TextAreaControl | — |
| 4 | TargetURL | URL | text(2048) | No | URLSelector | — |

### BDO.NavigationThirdLevelItem — _Navigation third level item_

- **Class ID:** 5570
- **Coupled table:** `BDO_NavigationThirdLevelItem`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Navigation/* (27 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NavigationThirdLevelItemID | NavigationThirdLevelItemID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | TargetURL | URL | text(2048) | No | URLSelector | — |

### BDO.NewsArticle — _News Article_

- **Class ID:** 5508
- **Coupled table:** `BDO_NewsArticle`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.ContentPage`
- **Used at:** /News/* (15 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NewsArticleID | NewsArticleID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | ShowTitle | Show title | boolean | No | CheckBoxControl | — |
| 4 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 5 | ShowDescription | Show description | boolean | No | CheckBoxControl | — |
| 6 | Content | Content | longtext | No | HtmlAreaControl | — |
| 7 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 8 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 9 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 10 | UpdatedOn | Updated on | datetime | No | CalendarControl | — |
| 11 | ShowSidebar | Show sidebar | boolean | No | CheckBoxControl | — |
| 12 | ShowPrintButton | Show print button | boolean | No | CheckBoxControl | — |
| 13 | DownloadButtonAttachment | Download button attachment | text(200) | No | MediaSelectionControl | — |
| 14 | ShowSocialMediaButtons | Show social media buttons | boolean | No | CheckBoxControl | — |
| 15 | ShowCallToAction | Show call to action | boolean | No | CheckBoxControl | — |
| 16 | CallToActionDescription | Call to action description | text(200) | No | TextBoxControl | — |
| 17 | CallToActionButtonText | Call to action button text | text(50) | No | TextBoxControl | — |
| 18 | CallToActionButtonUrl | Call to action button URL | text(200) | No | URLSelector | — |
| 19 | Image | Image | text(250) | No | MediaSelectionControl | — |
| 20 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 21 | ContentType | Type | text(1000) | No | MultiSelector | — |
| 22 | MetadataBusinessLines | Business lines | text(200) | No | MultiSelector | — |
| 23 | MetadataServiceAreas | Service areas | text(500) | No | MultiSelector | — |
| 24 | MetadataServices | Services | text(200) | No | MultiSelector | — |
| 25 | MetadataIndustryCategories | Industry categories | text(200) | No | MultiSelector | — |
| 26 | MetadataIndustries | Industries | text(200) | No | MultiSelector | — |
| 27 | MicrositeMasterPages | Microsite master pages | text(200) | No | MultiSelector | — |
| 28 | MicrositePages | Microsite pages | text(200) | No | MultiSelector | — |
| 29 | MetadataRssCategory | RSS category | text(200) | No | MultiSelector | — |
| 30 | MetadataRssImage | RSS Image | text(200) | No | MediaSelectionControl | — |
| 31 | RelevantContactPerson | Relevant contact people | text(1000) | No | MultiSelector | — |
| 32 | PeopleSort | People sort | longtext | No | BDO.InsightPeopleSort | — |
| 33 | RelatedExternalPeople | Related external people | text(1000) | No | MultiSelector | — |
| 34 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 35 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 36 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 37 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 38 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 39 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 40 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 41 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.ContentPage`.

### BDO.NewsGroup — _News Group_

- **Class ID:** 5509
- **Coupled table:** `BDO_NewsGroup`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /News/* (7 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | NewsGroupID | NewsGroupID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | Description | Description | text(200) | No | TextAreaControl | — |

### BDO.Person — _Person_

- **Class ID:** 5515
- **Coupled table:** `BDO_Person`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Our-People/* (33 pages), /Blogs/* (13 pages), /People/* (11 pages), /Our-people/Person-Media, /Our-people/Person-Attach, /Our-people/Person-Another-Site, /Section-blogs/Section-blogs/blog-contributor/contributor-person, /Section-Blog/Blog-group/contributors/Name-last

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | PersonID | PersonID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | PersonFirstName | First name | text(200) | No | TextBoxControl | — |
| 4 | PersonSurnamePrefixes | Surname Prefixes | text(200) | No | TextBoxControl | — |
| 5 | PersonLastName | Last name | text(200) | No | TextBoxControl | — |
| 6 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 7 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 8 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 9 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 10 | PersonJobTitle | Job title | text(200) | No | TextBoxControl | — |
| 11 | PersonPhone | Office phone number | text(200) | No | TextBoxControl | — |
| 12 | PersonMobilePhone | Mobile phone number | text(200) | No | TextBoxControl | — |
| 13 | PersonDirectDialNumber | Direct dial number | text(200) | No | TextBoxControl | — |
| 14 | PersonEmail | E-mail | text(200) | No | TextBoxControl | — |
| 15 | EnableForm | Enable Contact Form | boolean | No | CheckBoxControl | — |
| 16 | EnableVCard | Enable Vcard | boolean | No | CheckBoxControl | — |
| 17 | PersonCredentials | Credentials | text(200) | No | MultiSelector | — |
| 18 | MetadataOfficeLocation | Office location | text(200) | No | MultiSelector | — |
| 19 | MetadataProfileGroups | Profile Groups | text(4000) | No | MultiSelector | — |
| 20 | MetadataBusinessLines | Business lines | text(4000) | No | MultiSelector | — |
| 21 | MetadataServiceAreas | Service areas | text(200) | No | MultiSelector | — |
| 22 | MetadataServices | Services | text(200) | No | MultiSelector | — |
| 23 | MetadataSubServices | Sub services | text(200) | No | MultiSelector | — |
| 24 | MetadataIndustryCategories | Industry categories | text(200) | No | MultiSelector | — |
| 25 | MetadataIndustries | Industries | text(200) | No | MultiSelector | — |
| 26 | MetadataIndustryServices | Industry services | text(200) | No | MultiSelector | — |
| 27 | MetadataSpecialtiesCategories | Specialties categories | text(200) | No | MultiSelector | — |
| 28 | MetadataSpecialtiesAreas | Specialties areas | text(200) | No | MultiSelector | — |
| 29 | MetadataSpecialtiesPages | Specialty pages | text(200) | No | MultiSelector | — |
| 30 | MicrositeMasterPages | Microsite master pages | text(200) | No | MultiSelector | — |
| 31 | MicrositePages | Microsite pages | text(200) | No | MultiSelector | — |
| 32 | Facebook | Facebook link | text(200) | No | TextBoxControl | — |
| 33 | Twitter | Twitter link | text(200) | No | TextBoxControl | — |
| 34 | LinkedIn | LinkedIn link | text(200) | No | TextBoxControl | — |
| 35 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 36 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 37 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 38 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 39 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 40 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 41 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 42 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Presenter — _Presenter_

- **Class ID:** 5624
- **Coupled table:** `BDO_Presenter`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Events/* (22 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | PresenterID | PresenterID | integer | No | — | — |
| 2 | Name | Name | text(200) | No | TextBoxControl | — |
| 3 | Title | Title / Description | text(200) | No | TextBoxControl | — |
| 4 | Link | Link | text(200) | No | TextBoxControl | — |

### BDO.RemoteDeal — _Remote Deal_

- **Class ID:** 5701
- **Coupled table:** `BDO_RemoteDeal`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Deals/* (18 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | RemoteDealID | RemoteDealID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(500) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | Industry | Industry | text(1000) | No | TextBoxControl | — |
| 7 | SubIndustry | Sub Industry | text(1000) | No | TextBoxControl | — |
| 8 | IndustriesSelector | Industry~Sub-industry | text(1000) | No | BDO.IndustrySelector | — |
| 9 | DealType | Deal type | text(1000) | No | MultiSelector | — |
| 10 | DateField | Date | date | No | CalendarControl | — |
| 11 | DealCountry | Country | text(200) | No | TextBoxControl | — |
| 12 | OriginalSiteGUID | — | guid | No | — | — |
| 13 | OriginalPageGUID | — | guid | No | — | — |
| 14 | OriginalPageURL | Original page URL | text(200) | No | TextBoxControl | — |
| 15 | OriginalModifiedWhen | — | datetime | No | — | — |
| 16 | ForceUpdateOnNextSync | Force update on next sync | boolean | No | CheckBoxControl | — |
| 17 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

### BDO.Rss — _RSS_

- **Class ID:** 5564
- **Coupled table:** `BDO_Rss`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /RSS/Insights-RSS, /RSS/Deals, /RSS/News-RSS, /Blogs/Tech-Media-Watch-Blog/RSS, /Blogs/IT-Blogs/IT-Blogs-RSS, /RSS-(2)/RSS-Feed-Title

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | RssID | RssID | integer | No | — | — |
| 2 | RssFeedTitle | Feed title | text(200) | No | TextBoxControl | — |
| 3 | RssFeedDescription | Feed description | text(400) | No | TextAreaControl | — |
| 4 | RssCategory | RSS category | text(200) | No | TextBoxControl | — |
| 5 | RssPath | Path | guid | No | selectdocument | — |
| 6 | RssTopN | Top N | integer | No | TextBoxControl | — |
| 7 | RssPublic | Show feed publicly | boolean | No | CheckBoxControl | — |

### BDO.Search — _Search_

- **Class ID:** 5606
- **Coupled table:** `BDO_Search`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Search/* (6 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SearchID | SearchID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionAbout — _Section About_

- **Class ID:** 5538
- **Coupled table:** `Bdo_SectionAbout`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /About-Us, /About-Us, /Accessibility, /About, /Section-about, /Widget-content

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionAboutID | SectionAboutID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionBlogs — _Section Blogs_

- **Class ID:** 5614
- **Coupled table:** `BDO_SectionBlogs`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Blogs, /Blogs, /Section-blogs, /Section-Blog

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionBlogsID | SectionBlogsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ShowCopyUrlButtonInBlogPage | Show copy URL button in Blog Page | boolean | No | CheckBoxControl | — |
| 18 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 19 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 20 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 21 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 22 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 24 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 25 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionBusinessStrategies — _Section Business Strategies_

- **Class ID:** 5679
- **Coupled table:** `BDO_SectionBusinessStrategies`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Business-strategies, /Business-Strategies

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionBusinessStrategiesID | SectionBusinessStrategiesID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MenuBackgroundImage | Menu background image | text(200) | No | MediaSelectionControl | — |
| 18 | MenuBackgroundImageAltText | Background image alt text | text(200) | No | TextBoxControl | — |
| 19 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 20 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 21 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 23 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 24 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 25 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 26 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionCareers — _Section Careers_

- **Class ID:** 5558
- **Coupled table:** `BDO_SectionCareers`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Careers/* (4 pages), /Section-Careers

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionCareersID | SectionCareersID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ShowCopyUrlButtonInJobOpportunity | Show copy URL button in Job Opportunity Page | boolean | No | CheckBoxControl | — |
| 18 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 19 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 20 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 21 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 22 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 24 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 25 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionDeals — _Section Deals_

- **Class ID:** 5549
- **Coupled table:** `BDO_SectionDeals`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Deals/* (4 pages), /Section-Deals, /Deal-From-Integrations-For-demo

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionDealsID | SectionDealsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | SectionDealsFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 8 | SectionDealsFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 9 | ShowCopyUrlButtonInDealPage | Show copy URL button in Deal Page | boolean | No | CheckBoxControl | — |
| 10 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 11 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 12 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 13 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 14 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 15 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 16 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 17 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionEvents — _Section Events_

- **Class ID:** 5518
- **Coupled table:** `BDO_SectionEvents`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Events, /Events

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionEventsID | SectionEventsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | EventsWebinarsListTitle | Events & webinars list title | text(200) | No | TextBoxControl | — |
| 18 | EventsWebinarsListDescription | Events & webinars list description | text(200) | No | TextBoxControl | — |
| 19 | EventsWebinarsListFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 20 | EventsWebinarsListFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 21 | EventsWebinarsListFeaturedPages | Featured events & webinars | text(200) | No | Uni_selector |  → cms.document |
| 22 | EventsWebinarsListAdvancedSearchDescription | Advanced search description | text(200) | No | TextBoxControl | — |
| 23 | EventsWebinarsListAdvancedSearchLinkText | Advanced search link text | text(200) | No | TextBoxControl | — |
| 24 | EventsWebinarsListAdvancedSearchLinkUrl | Advanced search link URL | text(200) | No | URLSelector | — |
| 25 | ShowPastEvents | Show past events | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 27 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 28 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 29 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 30 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 31 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 32 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 33 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionExternalPeople — _Section Contributors_

- **Class ID:** 5707
- **Coupled table:** `BDO_SectionExternalPeople`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /External-People, /External-People

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionExternalPeopleID | SectionExternalPeopleID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.SectionIndustries — _Section Industries_

- **Class ID:** 5529
- **Coupled table:** `BDO_SectionIndustries`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Industries, /Section-indsutries, /Industries

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionIndustriesID | SectionIndustriesID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | GridTitle | Grid Title | text(200) | No | TextBoxControl | — |
| 18 | GridSummary | Grid Summary | longtext | No | HtmlAreaControl | — |
| 19 | ShowMultiLinks | Show multi links | boolean | No | CheckBoxControl | — |
| 20 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 21 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 22 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 24 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 26 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 27 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionInsightsPage — _Section Insights Page_

- **Class ID:** 5543
- **Coupled table:** `BDO_SectionInsightsPage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.ContentSectionPage`
- **Used at:** /Insights/* (4 pages), /Section-Insights, /Section-insights

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionInsightsPageID | SectionInsightsPageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ItemListTitle | Item list title | text(200) | No | TextBoxControl | — |
| 18 | ItemListDescription | Item list description | text(200) | No | TextBoxControl | — |
| 19 | ItemListFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 20 | InsightListFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 21 | InsightListFeaturedItems | Featured items | text(200) | No | Uni_selector |  → cms.document.bdo.insight |
| 22 | ItemListAdvancedSearchDescription | Advanced search description | text(200) | No | TextBoxControl | — |
| 23 | ItemListAdvancedSearchLinkText | Advanced search link text | text(200) | No | TextBoxControl | — |
| 24 | ItemListAdvancedSearchLinkUrl | Advanced search link URL | text(200) | No | URLSelector | — |
| 25 | ShowCopyUrlButtonInInsightPage | Show copy URL button in Insight Page | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 27 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 28 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 29 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 30 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 31 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 32 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 33 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.ContentSectionPage`.

### BDO.SectionLegal — _Section Legal_

- **Class ID:** 5556
- **Coupled table:** `BDO_SectionLegal`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Legal, /Privacy-policy, /Section-Legal

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionLegalID | SectionLegalID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionMicrosites — _Section Microsites_

- **Class ID:** 5514
- **Coupled table:** `BDO_SectionMicrositesPage`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Microsites, /Microsites, /Microsites, /Microsites-staging, /Digital

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionMicrositesPageID | SectionMicrositesPageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionNews — _Section News_

- **Class ID:** 5507
- **Coupled table:** `BDO_SectionNews`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.ContentSectionPage`
- **Used at:** /News, /News, /News

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionNewsID | SectionNewsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ItemListTitle | Item list title | text(200) | No | TextBoxControl | — |
| 18 | ItemListDescription | Item list description | text(200) | No | TextBoxControl | — |
| 19 | ItemListFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 20 | ItemListFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 21 | ItemListFeaturedItems | Featured items | text(200) | No | Uni_selector |  → cms.document.bdo.newsarticle |
| 22 | ItemListAdvancedSearchDescription | Advanced search description | text(200) | No | TextBoxControl | — |
| 23 | ItemListAdvancedSearchLinkText | Advanced search link text | text(200) | No | TextBoxControl | — |
| 24 | ItemListAdvancedSearchLinkUrl | Advanced search link URL | text(200) | No | URLSelector | — |
| 25 | ShowCopyUrlButtonInNewsArticle | Show copy URL button in News Article | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 27 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 28 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 29 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 30 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 31 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 32 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 33 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.ContentSectionPage`.

### BDO.SectionPeoplePage — _Section People Page_

- **Class ID:** 5539
- **Coupled table:** `BDO_SectionPeoplePage`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /People, /People, /People, /Our-People, /Our-People, /Our-people

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionPeoplePageID | SectionPeoplePageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | PeopleListFilteringEnabled | Enable filtering | boolean | No | CheckBoxControl | — |
| 18 | PeopleListFilters | Filters | text(200) | No | MultipleChoiceControl | — |
| 19 | PeopleListOrderingEnabled | Enable ordering | boolean | No | CheckBoxControl | — |
| 20 | PeopleListDefaultOrder | Default order | text(200) | No | RadioButtonsControl | — |
| 21 | ClarificationText | — | text(1) | No | LabelControl | — |
| 22 | ShowAuthoredInsights | Show authored content | boolean | No | CheckBoxControl | — |
| 23 | AuthoredInsightsTitle | Title | text(200) | No | TextBoxControl | — |
| 24 | AuthoredInsightsDescription | Description | text(2000) | No | TextBoxControl | — |
| 25 | AuthoredInsightsBackgroundImageUrl | Background image | text(200) | No | MediaSelectionControl | — |
| 26 | DisplayedAuthoredContentPageTypes | Displayed authored content page types | text(200) | No | MultipleChoiceControl | — |
| 27 | EnableForm | Enable Contact Form in all bio pages | boolean | No | CheckBoxControl | — |
| 28 | DisplayEmailAddressInPersonPage | Display email address in person page | boolean | No | CheckBoxControl | — |
| 29 | DisplayFullEmailAddress | Display full email address | boolean | No | CheckBoxControl | — |
| 30 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 31 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 32 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 33 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 34 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 35 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 36 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 37 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionRss — _Section RSS_

- **Class ID:** 5565
- **Coupled table:** `BDO_SectionRss`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /RSS, /RSS-(2), /RSS-(1)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionRssID | SectionRssID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionServices — _Section Services_

- **Class ID:** 5535
- **Coupled table:** `BDO_SectionServices`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Services, /Services, /Services, /Advisory, /Section-Services, /საქართველოში

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionServicesID | SectionServicesID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | GridTitle | Grid Title | text(200) | No | TextBoxControl | — |
| 18 | GridSummary | Grid Summary | longtext | No | HtmlAreaControl | — |
| 19 | ShowMultiLinks | Show multi links | boolean | No | CheckBoxControl | — |
| 20 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 21 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 22 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 24 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 26 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 27 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionSpecialties — _Section Specialties_

- **Class ID:** 5554
- **Coupled table:** `BDO_SectionSpecialties`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Specialties, /Specialties

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionSpecialtiesID | SectionSpecialtiesID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | GridTitle | Grid Title | text(200) | No | TextBoxControl | — |
| 18 | GridSummary | Grid Summary | longtext | No | HtmlAreaControl | — |
| 19 | ShowMultiLinks | Show multi links | boolean | No | CheckBoxControl | — |
| 20 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 21 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 22 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 23 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 24 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 26 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 27 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionTestimonials — _Section Testimonials_

- **Class ID:** 5548
- **Coupled table:** `BDO_SectionTestimonials`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Testimonials, /Testimonials-(Lape)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionTestimonialsID | SectionTestimonialsID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SectionWidgetContent — _Section Widget Content_

- **Class ID:** 5768
- **Coupled table:** `BDO_SectionWidgetContent`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Section-Widget-Content/* (7 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SectionWidgetContentID | SectionWidgetContentID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |

### BDO.Service — _Service_

- **Class ID:** 5533
- **Coupled table:** `BDO_Service`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /საქართველოში/* (7 pages), /Advisory/Advisory/BDO-Digital/BDO-Digital-Service, /Services/Business-line/Service-Area/Service

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ServiceID | ServiceID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 18 | SideNavigationTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 20 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 21 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 23 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 24 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 25 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 26 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.ServiceArea — _Service Area_

- **Class ID:** 5536
- **Coupled table:** `BDO_ServiceArea`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /საქართველოში/* (22 pages), /Advisory/* (7 pages), /Section-Services/Advisory/Audit-and-Advisory, /Services/Business-line/Service-Area

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ServiceAreaID | ServiceAreaID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | TileIcon | Tile icon | file | No | DirectUploadControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 9 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 10 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 11 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 12 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 13 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 14 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 15 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 16 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 17 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 18 | ContentTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | ContentBody | Content | longtext | No | HtmlAreaControl | — |
| 20 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 21 | SideNavigationTitle | Title | text(200) | No | TextBoxControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Sitemap — _Sitemap_

- **Class ID:** 5609
- **Coupled table:** `BDO_Sitemap`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Sitemap, /Sitemap, /Sitemap

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SitemapID | SitemapID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SpecialtiesArea — _Specialties Area_

- **Class ID:** 5553
- **Coupled table:** `BDO_SpecialtiesArea`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Specialties/* (6 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SpecialtiesAreaID | SpecialtiesAreaID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ContentTitle | Title | text(200) | No | TextBoxControl | — |
| 18 | ContentBody | Content | longtext | No | HtmlAreaControl | — |
| 19 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 20 | SideNavigationTitle | Title | text(200) | No | TextBoxControl | — |
| 21 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 22 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 23 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 24 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 25 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 26 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 27 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 28 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SpecialtiesCategory — _Specialties Category_

- **Class ID:** 5551
- **Coupled table:** `BDO_SpecialtiesCategory`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Specialties/* (7 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SpecialtiesCategoryID | SpecialtiesCategoryID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | BusinessLineBackgroundImage | Specialties category background image | text(200) | No | MediaSelectionControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 9 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 10 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 11 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 12 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 13 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 14 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 15 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 16 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 17 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 18 | ContentTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | ContentBody | Content | longtext | No | HtmlAreaControl | — |
| 20 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 21 | SideNavigationTitle | Title | text(200) | No | TextBoxControl | — |
| 22 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 23 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 24 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 25 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 26 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 27 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 28 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 29 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SpecialtiesPage — _Specialties Page_

- **Class ID:** 5552
- **Coupled table:** `BDO_SpecialtiesPage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Specialties/* (4 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SpecialtiesPageID | SpecialtiesPageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | ShowSideNavigation | Show side navigation | boolean | No | CheckBoxControl | — |
| 18 | SideNavigationTitle | Title | text(200) | No | TextBoxControl | — |
| 19 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 20 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 21 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 23 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 24 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 25 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 26 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.StatusCode — _Status Code_

- **Class ID:** 5602
- **Coupled table:** `BDO_StatusCode`
- **URL pattern:** —
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Error-Pages/* (4 pages), /Status-Code-Pages/500-Internal-Server-Error, /Status-Code-Pages/404-Page-Not-Found

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | StatusCodeID | StatusCodeID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | HttpStatusCode | Http Status Code | integer | No | DropDownListControl | — |
| 5 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 6 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 9 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 10 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 11 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 12 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 13 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 14 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 15 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Subscribe — _Subscribe_

- **Class ID:** 5620
- **Coupled table:** `BDO_Subscribe`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Subscribe, /Subscribe, /Subscribe, /Lape-Subscribe-Edited

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SubscribeID | SubscribeID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | FormType | Form type | text(200) | No | DropDownListControl | — |
| 18 | EmbedCode | Embed code | longtext | No | TextAreaControl | — |
| 19 | Information | — | boolean | No | LabelControl | — |
| 20 | ShowCompanyField | Show company field | boolean | No | CheckBoxControl | — |
| 21 | IsCompanyRequired | Is company field required | boolean | No | CheckBoxControl | — |
| 22 | ShowJobTitleField | Show job title field | boolean | No | CheckBoxControl | — |
| 23 | IsJobTitleRequired | Is job title field required | boolean | No | CheckBoxControl | — |
| 24 | ShowCountryField | Show country field | boolean | No | CheckBoxControl | — |
| 25 | IsCountryRequired | Is country required | boolean | No | CheckBoxControl | — |
| 26 | AddConsentToForm | Add consent field | boolean | No | CheckBoxControl | — |
| 27 | RecaptchaUseV3 | Use V3 | boolean | No | CheckBoxControl | — |
| 28 | RecaptchaScoreTreshhold | Score Threshold | decimal(28) | No | TextBoxControl | — |
| 29 | RedirectPageOnFormSubmission | Redirect to page on form submission | guid | No | selectdocument | — |
| 30 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 31 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 32 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 33 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 34 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 35 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 36 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 37 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SubscribeConfirm — _Subscribe - Confirm_

- **Class ID:** 5621
- **Coupled table:** `BDO_SubscribeConfirm`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Subscribe/Subscribe-Confirm, /Lape-Subscribe-Edited/Lape-Subscription-Confirmation

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SubscribeConfirmID | SubscribeConfirmID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | SuccessfulSubscribeMessage | Successful approval text | longtext | No | HtmlAreaControl | — |
| 8 | UnsuccessfulSubscribeMessage | Unsuccessful approval text | longtext | No | HtmlAreaControl | — |
| 9 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 10 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 11 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 13 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 14 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 15 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 16 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SubscribeRemove — _Subscribe - Remove_

- **Class ID:** 5622
- **Coupled table:** `BDO_SubscribeRemove`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Subscribe/Unsubscribe-confirm, /Lape-Subscribe-Edited/Lape-Unsubscription-Confirmation

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SubscribeRemoveID | SubscribeRemoveID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | SuccessfulUnubscribeMessage | Successful subscription cancellation text | longtext | No | HtmlAreaControl | — |
| 8 | UnsuccessfulUnsubscribeMessage | Unsuccessful subscription cancellation text | longtext | No | HtmlAreaControl | — |
| 9 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 10 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 11 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 13 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 14 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 15 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 16 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.SubService — _Sub-Service_

- **Class ID:** 5534
- **Coupled table:** `BDO_SubService`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /საქართველოში/* (4 pages), /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service, /Services/Business-line/Service-Area/Service/Sub-service

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SubServiceID | SubServiceID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | HeroLayout | Layout | text(200) | No | RadioButtonsControl | — |
| 8 | HeroTitle | Title | text(200) | No | TextBoxControl | — |
| 9 | HeroDescription | Description | text(200) | No | TextAreaControl | — |
| 10 | HeroBackgroundImage | Image | text(200) | No | MultiRenditionMediaSelector | — |
| 11 | HeroBackgroundImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 12 | HeroBackgroundImage_Mobile | Mobile image | text(200) | No | MediaSelectionControl | — |
| 13 | HeroBackgroundImage_MobileAltText | Mobile image alt text | text(200) | No | TextBoxControl | — |
| 14 | HeroCallToActionButtonType | CTA button type | text(200) | No | RadioButtonsControl | — |
| 15 | HeroCallToActionButtonText | CTA button text | text(200) | No | TextBoxControl | — |
| 16 | HeroCallToActionButtonUrl | CTA button URL | text(200) | No | URLSelector | — |
| 17 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 18 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 19 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 20 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 21 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 23 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 24 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.Testimonial — _Testimonial_

- **Class ID:** 5547
- **Coupled table:** `BDO_Testimonial`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Testimonials/Testimonial/Testimonial-page

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TestimonialID | TestimonialID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | ClientName | Client name | text(200) | No | TextBoxControl | — |
| 8 | ClientPosition | Position | text(200) | No | TextBoxControl | — |
| 9 | CompanyName | Company name | text(200) | No | TextBoxControl | — |
| 10 | Quote | Quote | text(500) | No | TextAreaControl | — |
| 11 | Country | Country | text(200) | No | TextBoxControl | — |
| 12 | ServiceLine | Service lines | text(200) | No | TextBoxControl | — |
| 13 | Industry | Industries | text(200) | No | TextBoxControl | — |
| 14 | ClientType | Client type | text(200) | No | TextBoxControl | — |
| 15 | TestimonialDate | Testimonial date | date | No | CalendarControl | — |
| 16 | DisplayedContacts | No. of contacts displayed in sidebar | integer | No | DropDownListControl | — |
| 17 | RelevantContactPerson | Relevant contact person | text(200) | No | TextBoxControl | — |
| 18 | PeopleSort | PeopleSort | longtext | No | TextBoxControl | — |
| 19 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 20 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 21 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 22 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 23 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 24 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 25 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 26 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.TestimonialType — _Testimonial Type_

- **Class ID:** 5546
- **Coupled table:** `BDO_TestimonialType`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Testimonials/Testimonial, /Testimonials-(Lape)/Testimonial

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TestimonialTypeID | TestimonialTypeID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.ThankYouConversionPage — _Thank You/Conversion Page_

- **Class ID:** 5607
- **Coupled table:** `BDO_ThankYouConversionPage`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Thank-you/* (6 pages), /Widget-content/* (5 pages), /Business-Strategies/Thank/you, /Business-Strategies/thank-(1)/you, /Business-Strategies/Gated-Download, /Insights/Test-of-gated-downloads-form, /Insights/Gated-downloads/Download-the-report, /RSS/Test-page, /Industries/Gated-downloads/Download-the-report

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ThankYouConversionPageID | ThankYouConversionPageID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.ThankYouConversionPages — _Thank You/Conversion Pages_

- **Class ID:** 5608
- **Coupled table:** `BDO_ThankYouConversionPages`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** `BDO.Metadata`
- **Used at:** /Thank-you, /Thank-you, /Thank-you, /Business-Strategies/Thank, /Business-Strategies/thank-(1), /Widget-content/In-Focus-pages-(1), /Widget-content/FAQ-pages, /RK-Downloads, /Industries/Gated-downloads, /Insights/Gated-downloads

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ThankYouConversionPagesID | ThankYouConversionPagesID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 4 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 5 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 6 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 7 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 8 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 9 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 10 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 11 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 12 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 13 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 14 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.Metadata`.

### BDO.TrendingTopic — _Trending topic_

- **Class ID:** 5594
- **Coupled table:** `BDO_TrendingTopic`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Homepage/* (5 pages), /Home/Trending-topics/Topic-1, /Home/Featured-topics/t1, /Home-page/Featured-topics/Trending-topic

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TrendingTopicID | TrendingTopicID | integer | No | — | — |
| 2 | Title | Title | text(200) | No | TextBoxControl | — |
| 3 | ImageUrl | Image | text(200) | No | MediaSelectionControl | — |
| 4 | ImageAltText | Image alt text | text(200) | No | TextBoxControl | — |
| 5 | CTANodeGuid | CTA Link | guid | No | selectdocument | — |
| 6 | FeaturedItems | Featured items (3) | text(200) | No | Uni_selector |  → cms.document |

### BDO.TrendingTopics — _Trending topics_

- **Class ID:** 5593
- **Coupled table:** `BDO_TrendingTopics`
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Home/Trending-topics, /Home/Featured-topics, /Homepage/Featured-topics, /Homepage/Featured-topics, /Home-page/Featured-topics

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TrendingTopicsID | TrendingTopicsID | integer | No | — | — |
| 2 | Heading | Heading | text(200) | No | TextBoxControl | — |

### BDO.Webinar — _Webinar_

- **Class ID:** 5517
- **Coupled table:** `BDO_Webinar`
- **URL pattern:** —
- **Page Builder:** Enabled
- **Inherits from:** `BDO.EventBase`
- **Used at:** /Events/* (14 pages)

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | WebinarID | WebinarID | integer | No | — | — |
| 2 | MetadataTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | ShowTitle | Show title | boolean | No | CheckBoxControl | — |
| 4 | MetadataDescription | Description | longtext | No | HtmlAreaControl | — |
| 5 | MetadataTeaserImage | Teaser image | text(200) | No | MediaSelectionControl | — |
| 6 | MetadataTeaserImageAltText | Teaser image alt text | text(200) | No | TextBoxControl | — |
| 7 | MetadataCanonical | Canonical link | text(2000) | No | TextBoxControl | — |
| 8 | EventPostDescription | Post event description | text(800) | No | TextAreaControl | — |
| 9 | CustomBodyText | Calendar custom body text | longtext | No | HtmlAreaControl | — |
| 10 | EventDateFrom | Date from | datetime | No | CalendarControl | — |
| 11 | EventDateTo | Date to | datetime | No | CalendarControl | — |
| 12 | EventTimeOverride | Time text override | text(100) | No | TextBoxControl | — |
| 13 | EventDateOverride | Date text Override | text(200) | No | TextBoxControl | — |
| 14 | EventIsPrivate | Is This Event Private | boolean | No | CheckBoxControl | — |
| 15 | EventAllDay | All-day event | boolean | No | CheckBoxControl | — |
| 16 | AllowRegistration | You can register for this event | boolean | No | CheckBoxControl | — |
| 17 | EventType | Type | text(200) | No | MultiSelector | — |
| 18 | DisablePrintAndShare | Disable print and share | boolean | No | CheckBoxControl | — |
| 19 | DisableAddToCalendar | Disable 'Add to calendar' | boolean | No | CheckBoxControl | — |
| 20 | ShowPastEvent | Show past event | boolean | No | CheckBoxControl | — |
| 21 | RegistrationType | Registration type | text(200) | No | DropDownListControl | — |
| 22 | RegistrationFormLink | Registration form link | text(2000) | No | URLSelector | — |
| 23 | CpeEvent | Continuing professional education event | boolean | No | CheckBoxControl | — |
| 24 | ProgramLevel | Program level | text(200) | No | DropDownListControl | — |
| 25 | CpeCount | CPE Count | text(50) | No | TextBoxControl | — |
| 26 | CpeCreditNotes | CPE Credit Notes | text(100) | No | TextBoxControl | — |
| 27 | CpeDescription | CPE Description | longtext | No | HtmlAreaControl | — |
| 28 | EventAttachment | Attachment  | text(200) | No | MediaSelectionControl | — |
| 29 | EventVideo | Video | longtext | No | TextBoxControl | — |
| 30 | MetadataBusinessIssues | Business issue | text(200) | No | MultiSelector | — |
| 31 | MetadataIndustries | Industries | text(200) | No | MultiSelector | — |
| 32 | MetadataIndustryCategories | Industry categories | text(200) | No | MultiSelector | — |
| 33 | MetadataServices | Services | text(200) | No | MultiSelector | — |
| 34 | MetadataBusinessLines | Business lines | text(200) | No | MultiSelector | — |
| 35 | MetadataServiceAreas | Service areas | text(200) | No | MultiSelector | — |
| 36 | MetadataOfficeLocation | Office location | text(200) | No | MultiSelector | — |
| 37 | MetadataSpecialtiesCategories | Specialty categories | text(200) | No | MultiSelector | — |
| 38 | MetadataSpecialtiesAreas | Specialties areas | text(200) | No | MultiSelector | — |
| 39 | MetadataSpecialtiesPages | Specialty pages | text(200) | No | MultiSelector | — |
| 40 | MicrositeMasterPages | Microsite master pages | text(200) | No | MultiSelector | — |
| 41 | MicrositePages | Microsite pages | text(200) | No | MultiSelector | — |
| 42 | MetadataRssCategory | RSS category | text(200) | No | MultiSelector | — |
| 43 | MetadataRssImage | RSS image | text(200) | No | MediaSelectionControl | — |
| 44 | EventLocationTitle | Location title | text(200) | No | TextBoxControl | — |
| 45 | EventLocationAddress1 | Location address | text(256) | No | TextBoxControl | — |
| 46 | EventLocationAddress2 | Location address 2 | text(256) | No | TextBoxControl | — |
| 47 | EventLocationCity | City | text(1000) | No | TextBoxControl | — |
| 48 | EventLocationState | City/state | text(200) | No | TextBoxControl | — |
| 49 | EventLocationZip | Location ZIP code | text(200) | No | TextBoxControl | — |
| 50 | EventLocationZipPosition | Zip/postal code before or after | text(100) | No | RadioButtonsControl | — |
| 51 | HideEventLocationZipComma | Hide event location Zip/postal code comma | boolean | No | CheckBoxControl | — |
| 52 | EventLocationCountry | Country | text(200) | No | TextBoxControl | — |
| 53 | ShowEventLocation | Show event location by coordinates | boolean | No | CheckBoxControl | — |
| 54 | EventLocationLongitude | Longitude | text(200) | No | TextBoxControl | — |
| 55 | EventLocationLatitude | Latitude | text(200) | No | TextBoxControl | — |
| 56 | EventContactName | Contact name | text(200) | No | TextBoxControl | — |
| 57 | EventContactPhone | Office phone number | text(200) | No | TextBoxControl | — |
| 58 | EventContactEmail | E-mail | text(200) | No | TextBoxControl | — |
| 59 | MetadataOGTitle | OG metadata title | text(60) | No | TextBoxControl | — |
| 60 | MetadataOGDescription | OG metadata description | text(500) | No | TextAreaControl | — |
| 61 | MetadataOGImage | OG metadata image | text(500) | No | MediaSelectionControl | — |
| 62 | MetadataOGTwitterImageSizeCheckbox | Use small image for Twitter (1:1) | boolean | No | CheckBoxControl | — |
| 63 | MetadataOGTwitterImage | Twitter OG metadata image | text(500) | No | MediaSelectionControl | — |
| 64 | MetadataNofollow | Nofollow | boolean | No | CheckBoxControl | — |
| 65 | MetadataNoindex | Noindex | boolean | No | CheckBoxControl | — |
| 66 | IncludeInSitemap | Include page in the sitemap | boolean | No | CheckBoxControl | — |

> Note: Inherits fields from `BDO.EventBase`.

### CMS.Folder — _Folder_

- **Class ID:** 5383
- **Coupled table:** — _(no custom data table, all data lives in CMS_Tree/CMS_Document)_
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** /Reusable-Content-Tab/Abc/Services, /Reusable-Content-Tab, /Status-Code-Pages, /Error-Pages

*No custom fields.*

### CMS.Root — _Root_

- **Class ID:** 1095
- **Coupled table:** — _(no custom data table, all data lives in CMS_Tree/CMS_Document)_
- **URL pattern:** None — container/folder type
- **Page Builder:** Disabled
- **Inherits from:** —
- **Used at:** //* (7 pages)

*No custom fields.*

### Unused Page Types

| Class Name | Display Name | Has Fields | Page Builder | Notes |
| ---------- | ------------ | ---------- | ------------ | ----- |
| BDO.ContentPage | Content Page | Yes | No | — |
| BDO.ContentSectionPage | Content Section Page | Yes | No | — |
| BDO.EventBase | EventBase | Yes | No | — |
| BDO.InsightSubscriptionConfirmationPage | Insight subscription confirmation page | Yes | No | — |
| BDO.InsightUnsubscriptionPage | Insight unsubscription page | Yes | No | — |
| BDO.Metadata | Metadata | Yes | No | — |
| Ecommerce.Transformations | E-commerce - Transformations | No | No | system type |

---

## Page Builder Components

- **Templates:** 0
- **Sections:** 9
- **Widgets:** 27
- **Page Builder-enabled page types:** `BDO.AboutPage`, `BDO.Blog`, `BDO.BlogPost`, `BDO.BusinessLine`, `BDO.BusinessStrategy`, `BDO.Career`, `BDO.CareerCategory`, `BDO.CareerContent`, `BDO.Contact`, `BDO.Deal`, `BDO.Event`, `BDO.EventRegistrationForm`, `BDO.HomePage`, `BDO.Industry`, `BDO.IndustryCategory`, `BDO.IndustryService`, `BDO.Insight`, `BDO.InsightCategory`, `BDO.InsightGroup`, `BDO.LegalPage`, `BDO.LocationCity`, `BDO.Locations`, `BDO.MicrositeMasterPage`, `BDO.MicrositePage`, `BDO.NewsArticle`, `BDO.Person`, `BDO.SectionAbout`, `BDO.SectionBlogs`, `BDO.SectionBusinessStrategies`, `BDO.SectionCareers`, `BDO.SectionDeals`, `BDO.SectionEvents`, `BDO.SectionIndustries`, `BDO.SectionInsightsPage`, `BDO.SectionServices`, `BDO.SectionSpecialties`, `BDO.Service`, `BDO.ServiceArea`, `BDO.SpecialtiesArea`, `BDO.SpecialtiesCategory`, `BDO.SpecialtiesPage`, `BDO.SubService`, `BDO.ThankYouConversionPage`, `BDO.Webinar`

### Page Templates

_None discovered_

### Sections

| Identifier | Properties | Used On Page Types |
| ---------- | ---------- | ------------------ |
| BDO.Section.Container | containerPadding (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.Deal, BDO.HomePage, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.LocationCity, BDO.Locations, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.Person, BDO.SectionAbout, BDO.SectionBusinessStrategies, BDO.SectionCareers, BDO.SectionEvents, BDO.SectionIndustries, BDO.SectionServices, BDO.Service, BDO.ServiceArea, BDO.SubService, BDO.ThankYouConversionPage |
| BDO.Section.FiveColumns | containerPadding (string), sectionsGap (string) | BDO.Insight |
| BDO.Section.FourColumns | containerPadding (string), sectionsGap (string) | BDO.Insight |
| BDO.Section.LocalNavigation | containerPadding (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.Career, BDO.CareerCategory, BDO.CareerContent, BDO.Event, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionAbout, BDO.SectionBlogs, BDO.SectionBusinessStrategies, BDO.SectionCareers, BDO.SectionIndustries, BDO.SectionInsightsPage, BDO.SectionServices, BDO.SectionSpecialties, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesArea, BDO.SpecialtiesCategory, BDO.SpecialtiesPage, BDO.SubService, BDO.Webinar |
| BDO.Section.OneThirdTwoThird | containerPadding (string), sectionsGap (string) | BDO.AboutPage, BDO.BlogPost, BDO.IndustryCategory, BDO.Insight, BDO.SectionServices, BDO.Service, BDO.ServiceArea |
| BDO.Section.ThreeColumns | containerPadding (string), sectionsGap (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.Deal, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.InsightCategory, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionCareers, BDO.SectionEvents, BDO.SectionServices, BDO.SpecialtiesArea |
| BDO.Section.TwoColumns | containerPadding (string), sectionsGap (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.LocationCity, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionCareers, BDO.SectionEvents, BDO.ServiceArea, BDO.ThankYouConversionPage |
| BDO.Section.TwoThirdOneThird | containerPadding (string), sectionsGap (string) | BDO.BlogPost, BDO.BusinessLine, BDO.IndustryCategory, BDO.Insight, BDO.MicrositePage |
| Kentico.DefaultSection | *(none)* | BDO.AboutPage, BDO.Blog, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.Career, BDO.CareerCategory, BDO.CareerContent, BDO.Contact, BDO.Deal, BDO.Event, BDO.EventRegistrationForm, BDO.HomePage, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.InsightCategory, BDO.InsightGroup, BDO.LegalPage, BDO.LocationCity, BDO.Locations, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.Person, BDO.SectionBlogs, BDO.SectionBusinessStrategies, BDO.SectionCareers, BDO.SectionDeals, BDO.SectionIndustries, BDO.SectionInsightsPage, BDO.SectionServices, BDO.SectionSpecialties, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesArea, BDO.SpecialtiesCategory, BDO.SpecialtiesPage, BDO.SubService, BDO.ThankYouConversionPage, BDO.Webinar |

### Widgets

| Identifier | Properties | Used On Page Types |
| ---------- | ---------- | ------------------ |
| BDO.Widget.Accordion | bottomMargin (string), content (string), deepLinkID (string), heading (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BusinessLine, BDO.Deal, BDO.IndustryCategory, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.Person, BDO.SectionCareers |
| BDO.Widget.Button | bottomMargin (string), buttonSide (string), link (string), target (string), text (string), theme (string), topMargin (string), type (string), widgetID (string) | BDO.BusinessLine, BDO.CareerContent, BDO.Deal, BDO.HomePage, BDO.Industry, BDO.IndustryService, BDO.Insight, BDO.InsightCategory, BDO.InsightGroup, BDO.Locations, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.SectionCareers, BDO.ServiceArea, BDO.ThankYouConversionPage |
| BDO.Widget.EditorsPick | backgroundImageAltText (string), backgroundImages (array), bottomMargin (string), description (string), featuredPages (array), filteringEnabled (boolean), filters (string), pages (array), seeAllLinkText (string), seeAllLinkURL (string), seeAllLinkURLTarget (string), title (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.Deal, BDO.IndustryCategory, BDO.Insight, BDO.LocationCity, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.Person, BDO.SectionBusinessStrategies, BDO.SectionSpecialties, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesArea, BDO.SubService |
| BDO.Widget.EventsWebinarsSlider | backgroundImageAltText (string), backgroundImages (array), bottomMargin (string), description (string), featuredEventsAndWebinars (array), filteringEnabled (boolean), filters (string), seeAllLinkText (string), seeAllLinkURL (string), seeAllLinkURLTarget (string), title (string), topMargin (string), widgetID (string) | BDO.BusinessLine, BDO.BusinessStrategy, BDO.CareerContent, BDO.Event, BDO.HomePage, BDO.Industry, BDO.IndustryCategory, BDO.Insight, BDO.LocationCity, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.SectionAbout, BDO.SectionCareers, BDO.Service, BDO.ServiceArea, BDO.Webinar |
| BDO.Widget.ExternalNavigation | externalLink (string), linkText (string), primaryButtonLinkTarget (string) | BDO.Insight |
| BDO.Widget.Faq | bottomMargin (string), hoverColour (string), layout (string), pages (array), title (string), topMargin (string), widgetID (null) | BDO.BusinessLine, BDO.Insight, BDO.ServiceArea |
| BDO.Widget.FlexibleBanner | backgroundImage (string), backgroundImageAltText (string), bottomMargin (string), buttonSide (string), description (string), layout (string), primaryButtonLinkTarget (string), primaryButtonText (string), primaryButtonType (string), primaryButtonUrl (string), secondaryButtonLinkTarget (string), secondaryButtonText (string), secondaryButtonType (string), secondaryButtonUrl (string), theme (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BusinessStrategy, BDO.CareerCategory, BDO.Deal, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionCareers, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesArea |
| BDO.Widget.FlexibleContent | bottomMargin (string), description (string), featuredPages (array), learnMoreButtonURLTarget (string), pages (array), title (string), topMargin (string), widgetID (string) | BDO.BlogPost, BDO.BusinessLine, BDO.IndustryCategory, BDO.Insight, BDO.Locations, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.Person, BDO.SectionSpecialties, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesPage, BDO.SubService |
| BDO.Widget.Hero | backgroundImage (string), backgroundImageAltText (string), ctaButtonText (string), ctaButtonType (string), ctaButtonUrl (string), ctaButtonUrlTarget (string), description (string), layout (string), mobileBackgroundImage (string), mobileBackgroundImageAltText (string), title (string), widgetID (string) | BDO.BlogPost, BDO.Deal, BDO.Event, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionDeals, BDO.ThankYouConversionPage, BDO.Webinar |
| BDO.Widget.HTML | htmlCode (string) | BDO.AboutPage, BDO.BusinessLine, BDO.Event, BDO.HomePage, BDO.Insight, BDO.LocationCity, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.SectionCareers, BDO.SectionEvents, BDO.Service, BDO.ServiceArea, BDO.Webinar |
| BDO.Widget.ImageWithText | backgroundImageAltText (string), backgroundImageURL (string), bottomMargin (string), buttonText (string), buttonType (string), buttonURL (string), description (string), embedCode (string), imageAltText (string), imageURL (string), mediaPosition (string), mediaType (string), primaryButtonLinkTarget (string), theme (string), title (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BusinessLine, BDO.Deal, BDO.Industry, BDO.IndustryCategory, BDO.Insight, BDO.LocationCity, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionBusinessStrategies, BDO.ServiceArea |
| BDO.Widget.InFocus | bottomMargin (string), imageAltText (string), imageURL (string), pages (array), subtitle (string), title (string), topMargin (string), widgetID (null) | BDO.AboutPage, BDO.BusinessLine, BDO.Insight, BDO.ServiceArea |
| BDO.Widget.InsightCarousel | backgroundImageAltText (string), backgroundImages (array), bottomMargin (string), description (string), featuredInsights (array), filteringEnabled (boolean), filters (string), seeAllLinkText (string), seeAllLinkURL (string), seeAllLinkURLTarget (string), title (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.HomePage, BDO.Industry, BDO.IndustryCategory, BDO.Insight, BDO.LocationCity, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.SectionAbout, BDO.ServiceArea, BDO.ThankYouConversionPage |
| BDO.Widget.KeyContacts | bottomMargin (string), contributors (array), description (string), isDescendingOrder (boolean), isOrderOverriden (boolean), orderCriteria (string), people (array), seeAllLinkText (string), seeAllLinkURL (string), seeAllLinkURLTarget (string), showOffice (boolean), title (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BusinessLine, BDO.Deal, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionCareers, BDO.SectionServices, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesArea |
| BDO.Widget.KeyTakeaways | backgroundColour (string), bottomMargin (string), content (string), contentAlignment (string), contentWidth (string), title (string), topMargin (string), widgetID (null) | BDO.Insight |
| BDO.Widget.LocalNavigation | linkText (string), widgetIdToLink (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.Event, BDO.Industry, BDO.IndustryCategory, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.SectionAbout, BDO.SectionCareers, BDO.ServiceArea, BDO.Webinar |
| BDO.Widget.NewsCarousel | backgroundImageAltText (string), backgroundImages (array), bottomMargin (string), description (string), featuredNews (array), filteringEnabled (boolean), filters (string), seeAllLinkText (null), seeAllLinkURL (null), seeAllLinkURLTarget (string), title (string), topMargin (string), widgetID (null) | BDO.AboutPage, BDO.BusinessLine, BDO.HomePage, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.Service, BDO.ServiceArea |
| BDO.Widget.QuoteCard | authorsJobTitle (string), bottomMargin (string), buttonText (string), buttonUrl (string), heading (string), image (string), imageAltText (string), primaryButtonLinkTarget (string), quotesAuthor (string), quoteText (string), size (string), subheading (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.Deal, BDO.HomePage, BDO.IndustryCategory, BDO.Insight, BDO.MicrositePage, BDO.SectionCareers, BDO.ServiceArea, BDO.SpecialtiesArea |
| BDO.Widget.RelatedContacts | bottomMargin (string), description (string), isDescendingOrder (boolean), orderCriteria (string), seeAllLinkText (null), seeAllLinkURL (null), showOffice (boolean), title (string), topMargin (string), widgetID (string) | BDO.BusinessLine, BDO.Deal, BDO.IndustryCategory, BDO.Insight, BDO.LocationCity, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.Service, BDO.ServiceArea |
| BDO.Widget.RelatedContentCarousel | backgroundImageAltText (string), backgroundImages (array), bottomMargin (string), description (string), featuredPages (array), filteringEnabled (boolean), filters (string), seeAllLinkText (string), seeAllLinkURL (string), seeAllLinkURLTarget (string), selectedPageTypes (string), title (string), topMargin (string), widgetID (null) | BDO.BusinessLine, BDO.Industry, BDO.IndustryCategory, BDO.Insight, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.Service, BDO.ServiceArea, BDO.SubService |
| BDO.Widget.RichText | bottomMargin (string), content (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.Career, BDO.Deal, BDO.EventRegistrationForm, BDO.HomePage, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.Insight, BDO.InsightCategory, BDO.LegalPage, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.NewsArticle, BDO.Person, BDO.SectionAbout, BDO.SectionBusinessStrategies, BDO.SectionCareers, BDO.SectionEvents, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesArea, BDO.SpecialtiesCategory, BDO.ThankYouConversionPage |
| BDO.Widget.SocialMediaButtons | bottomMargin (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BlogPost, BDO.Deal, BDO.HomePage, BDO.Insight, BDO.MicrositeMasterPage, BDO.NewsArticle, BDO.Person, BDO.Service |
| BDO.Widget.TabAccordion | bottomMargin (string), layout (string), pages (array), pageType (string), title (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BusinessLine, BDO.BusinessStrategy, BDO.Industry, BDO.IndustryCategory, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.SectionCareers, BDO.Service, BDO.ServiceArea, BDO.SpecialtiesCategory, BDO.SubService |
| BDO.Widget.TiledLinkSection | backgroundImageAltText (string), backgroundImages (array), bottomMargin (string), description (string), seeAllLinkText (string), seeAllLinkURL (string), seeAllLinkURLTarget (string), theme (string), tilePages (array), tilePageType (string), title (string), topMargin (string), widgetID (string) | BDO.AboutPage, BDO.BusinessLine, BDO.Deal, BDO.HomePage, BDO.Industry, BDO.IndustryCategory, BDO.IndustryService, BDO.SectionAbout, BDO.SectionIndustries, BDO.Service, BDO.ServiceArea |
| BDO.Widget.TrendingTopicsCarousel | bottomMargin (string), description (string), learnMoreButtonURLTarget (string), pages (array), title (string), topMargin (string), trendingTopicsPageType (string), widgetID (string) | BDO.BusinessLine, BDO.Deal, BDO.Industry, BDO.IndustryCategory, BDO.MicrositeMasterPage, BDO.MicrositePage, BDO.SectionInsightsPage, BDO.SectionServices, BDO.Service, BDO.ServiceArea, BDO.SubService |
| BDO.Widget.ViewGlobalLocations | bottomMargin (string), buttonLinkTarget (string), buttonText (string), buttonUrl (string), description (null), layout (string), theme (string), title (string), topMargin (string), widgetID (null) | BDO.AboutPage, BDO.BusinessLine, BDO.HomePage, BDO.LocationCity, BDO.SectionBusinessStrategies, BDO.SectionInsightsPage, BDO.SubService |
| Kentico.FormWidget | selectedForm (string) | BDO.AboutPage, BDO.BlogPost, BDO.BusinessLine, BDO.BusinessStrategy, BDO.HomePage, BDO.IndustryCategory, BDO.Insight, BDO.LegalPage, BDO.Locations, BDO.NewsArticle, BDO.Person, BDO.SectionAbout, BDO.SectionServices, BDO.ServiceArea, BDO.ThankYouConversionPage |

---

## Content References

#### BDO.AboutPage

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us/About-us | 19fb392c-bed1-468b-9186-d2861f5d8a8e | _(media file)_ |
| /About-Us/JJ-About | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (5 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us/JJ-About | e6619801-d131-4884-8621-7057df2b8d33 | BDO.Insight |
| /About-Us/JJ-About | 7ec96890-fff8-46b4-8f6d-9aa875cc2958 | BDO.Insight |
| /About-Us/JJ-About | 0b683d06-3896-4526-9b55-c6cd1f4b49c4 | BDO.Insight |
| /About-Us/JJ-About | ccbb88d5-439f-42fa-a6a3-9d9c601af76a | BDO.NewsArticle |
| /About-Us/JJ-About | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |

##### Widget References

**`BDO.Widget.InFocus`** — property `pages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us/MP-About | 2d774683-014b-4041-9579-7b83695a1f37 | BDO.InFocusPage |
| /About-Us/JJ-About/JJ-About-Widgets | cf209186-e1dc-4a66-a510-34d62b5c4b64 | BDO.InFocusPage |
| /About-Us/JJ-About/JJ-About-Widgets | 5fbbdc5c-f253-4d1a-8f04-b9ffaaac4cd8 | BDO.InFocusPage |
| /About-Us/JJ-About/JJ-About-Widgets | 9e0ffad7-3dc3-4670-91b6-8ff03853d8b9 | BDO.InFocusPage |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `contributors` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us/JJ-About | bd0fd333-660d-4d49-8923-087362394357 | BDO.ExternalPerson |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us/MP-About | 7712cb45-fec0-45b2-aadb-b8863d5718ac | BDO.SectionIndustries |
| /About-Us/MP-About | 4bd7f822-b92a-4a4d-b5f8-3259b954b60e | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us/About-page | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /About-Us/About-page | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /About-Us/About-page | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /About-Us/About-page | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |
| /About-Us/MP-About | fa57db89-10da-4f07-bb42-e9bdeb76b0c6 | BDO.Industry |
| /About-Us/MP-About | 19e1ca98-7b05-4c60-a556-59dbe2646eb6 | BDO.Industry |
| /About-Us/MP-About | 6fca946d-8ece-40be-8367-0e28854861a2 | BDO.Industry |
| /About-Us/MP-About | ad261786-6741-48d7-8d18-f8aa902d4a58 | BDO.Industry |

#### BDO.BlogPost

##### Page Type Field References

**property `Image`** — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Section-blogs/Section-blogs/Blog-post-group/Blog-post | d90d99a5-5165-45da-9c40-b02d66218c11 | _(media file)_ |
| /Section-Blog/Blog-group/Blog-post-group/Blog-post | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Blogs/Fraud-risk-management/Cyber-fraud/Uncovering-the-Hidden-Threat-Cyber-Fraud-Risk-Mana | 8a7c57bb-4cad-4452-bc92-124f138ca522 | BDO.Insight |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Blogs/Fraud-risk-management/Cyber-fraud/Uncovering-the-Hidden-Threat-Cyber-Fraud-Risk-Mana | ceecd594-c1da-421d-8633-39acd1ff1d09 | BDO.Insight |
| /Blogs/Fraud-risk-management/Cyber-fraud/Uncovering-the-Hidden-Threat-Cyber-Fraud-Risk-Mana | 8a7c57bb-4cad-4452-bc92-124f138ca522 | BDO.Insight |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Blogs/BDO-Healthcare/Healthcare/Health-Service-Capacity-Review-and-its-Impact | 894b7458-e0d7-44d0-9675-737da8bbd311 | BDO.SpecialtiesArea |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (7 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | 01576354-9d31-41d4-9cea-94ab15971c1c | — |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | 3c94e709-7f73-4fef-9753-386177a8709d | BDO.Insight |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | c8b2d233-8cef-4916-8fe6-d9d4a14d86b9 | BDO.Insight |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | 3ea0f6b1-b837-4f02-9ab5-a8d39f7606e1 | BDO.Insight |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | 89b75206-42e9-4b9d-9956-f6cfde5f6273 | BDO.Insight |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | f3a5ea76-0516-4f34-ada2-6bd9e37c1718 | BDO.Insight |
| /Blogs/IT-Blogs/Smartphones/New-blog-post | 85a652fd-4203-4ace-bbaa-e83f5f01690e | BDO.Insight |

#### BDO.BusinessLine

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/BDO-Consulting | 16b54232-f226-4d95-b13b-6ee04b4135ee | _(media file)_ |
| /საქართველოში/Consulting-Unternehmensberatung | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Consulting-Unternehmensberatung | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (20 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/BDO-Consulting | 0edb60c6-63d0-4762-aa34-26ec2cd8b371 | BDO.NewsArticle |
| /Advisory/BDO-Consulting | 6ab7d515-5751-4094-94b6-3e3b4252f3ab | BDO.NewsArticle |
| /Advisory/BDO-Consulting | 8a7c57bb-4cad-4452-bc92-124f138ca522 | BDO.Insight |
| /Advisory/BDO-Consulting | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Advisory/BDO-Consulting | df8eea5c-2e97-41ef-8005-e0ea9cefe1ac | BDO.BlogPost |
| /Advisory/BDO-Consulting | ea1e46b7-cfc6-472b-bf73-79fc8478578c | BDO.BlogPost |
| /საქართველოში/Consulting-Unternehmensberatung | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /საქართველოში/Consulting-Unternehmensberatung | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /საქართველოში/Consulting-Unternehmensberatung | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /საქართველოში/Consulting-Unternehmensberatung | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /საქართველოში/Consulting-Unternehmensberatung | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /საქართველოში/Consulting-Unternehmensberatung | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /საქართველოში/Consulting-Unternehmensberatung | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /საქართველოში/Demo-Business-line | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /საქართველოში/Demo-Business-line | d452bc7f-e57b-4000-9e12-910e074f5281 | BDO.Webinar |
| /საქართველოში/Demo-Business-line | b294c30e-f1c0-4191-9a68-e4942eed3b00 | BDO.EventRegistrationForm |
| /საქართველოში/Demo-Business-line | d452bc7f-e57b-4000-9e12-910e074f5281 | BDO.Webinar |
| /საქართველოში/Demo-Business-line | 2259dfde-71fe-4571-bcd9-81b03fb772d6 | BDO.EventRegistrationForm |
| /საქართველოში/Demo-Business-line | 9416914d-fa23-4f86-8a6b-1ba353fea15f | BDO.EventRegistrationForm |

##### Widget References

**`BDO.Widget.Faq`** — property `pages` — PageSelector (12 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory | 60f197e3-0060-4cae-be28-396d96d6cb9e | BDO.FaqPage |
| /Advisory/Advisory | 4f09d57f-6564-4b11-aa64-0868e9c808cc | BDO.FaqPage |
| /Advisory/Advisory | f5946848-5676-4145-a315-4ea19635bb47 | BDO.FaqPage |
| /Advisory/Advisory | 140de78d-87af-4cc8-b9de-9d734c4d36a8 | BDO.FaqPage |
| /Advisory/Advisory | 60f197e3-0060-4cae-be28-396d96d6cb9e | BDO.FaqPage |
| /Advisory/Advisory | 4f09d57f-6564-4b11-aa64-0868e9c808cc | BDO.FaqPage |
| /Advisory/Advisory | f5946848-5676-4145-a315-4ea19635bb47 | BDO.FaqPage |
| /Advisory/Advisory | 140de78d-87af-4cc8-b9de-9d734c4d36a8 | BDO.FaqPage |
| /Advisory/Advisory | 60f197e3-0060-4cae-be28-396d96d6cb9e | BDO.FaqPage |
| /Advisory/Advisory | 4f09d57f-6564-4b11-aa64-0868e9c808cc | BDO.FaqPage |
| /Advisory/Advisory | f5946848-5676-4145-a315-4ea19635bb47 | BDO.FaqPage |
| /Advisory/Advisory | 140de78d-87af-4cc8-b9de-9d734c4d36a8 | BDO.FaqPage |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (11 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Hellou | d7525b63-643c-4802-a715-fed303102269 | BDO.TestimonialType |
| /საქართველოში/Hellou | 72fac63a-000f-4fbc-b259-edf6559728c3 | BDO.NewsArticle |
| /საქართველოში/Hellou | 9103192c-8a58-41f3-b73c-0bb982f2accb | BDO.NewsArticle |
| /საქართველოში/Test | 673b0177-8e1c-4de7-992a-ddffc8ea7e95 | BDO.BusinessLine |
| /საქართველოში/Test | ede5b8dc-66fe-4cc6-ac71-c94f7536217a | BDO.BusinessLine |
| /საქართველოში/Test | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /საქართველოში/Test | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /საქართველოში/Test | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /საქართველოში/Test | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /საქართველოში/Test | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/Test | cb7d20d7-9046-4b22-8285-b9af87cc659c | BDO.SpecialtiesCategory |

##### Widget References

**`BDO.Widget.InFocus`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory | 8b03ab85-afda-43e3-930d-0deb3e4792a9 | BDO.InFocusPage |
| /Advisory/Advisory | cd7c7790-7723-446b-912b-aacc5dd6fb9e | BDO.InFocusPage |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/URL-Rædiræction-Tæst | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |
| /საქართველოში/Test | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (15 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |
| /საქართველოში/Advisory | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /საქართველოში/Advisory | c5f0ad09-48c0-4b5b-a50c-ead79ebd9b36 | BDO.Person |
| /საქართველოში/Advisory | f1f14a0d-1987-41e3-b16c-0d74d4a1bd24 | BDO.Person |
| /საქართველოში/Hellou | 1146c973-15d0-4dd9-854c-6db4f445d880 | BDO.Person |
| /საქართველოში/Hellou | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /საქართველოში/Hellou | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |
| /საქართველოში/Hellou | c5f0ad09-48c0-4b5b-a50c-ead79ebd9b36 | BDO.Person |
| /საქართველოში/Hellou | 899226ea-6cb6-4064-9a02-db026fe7705b | BDO.Person |
| /საქართველოში/Hellou | ff60f7cf-6863-4765-815a-de7342dd457a | BDO.Person |
| /საქართველოში/Test | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /საქართველოში/Consulting-Unternehmensberatung | c2ca32bb-1ab2-401e-ba56-d5b7526b3293 | BDO.Person |
| /საქართველოში/Consulting-Unternehmensberatung | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /საქართველოში/Consulting-Unternehmensberatung | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /საქართველოში/Consulting-Unternehmensberatung | 31d93727-03fe-454b-be19-e301777510d8 | BDO.Person |

##### Widget References

**`BDO.Widget.NewsCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Hellou | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |

##### Widget References

**`BDO.Widget.NewsCarousel`** — property `featuredNews` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Hellou | 72fac63a-000f-4fbc-b259-edf6559728c3 | BDO.NewsArticle |
| /საქართველოში/Hellou | 9103192c-8a58-41f3-b73c-0bb982f2accb | BDO.NewsArticle |
| /საქართველოში/Hellou | e89af266-df6a-44c0-9dbd-cca8f990fa29 | BDO.NewsArticle |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (44 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Advisory/Advisory | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Advisory/Advisory | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Advisory/Advisory | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory | 2a6ee9dd-b3bf-47a6-ab76-a426c6421b3f | BDO.ServiceArea |
| /Advisory/Advisory | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /Advisory/Advisory | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Advisory/Advisory | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Advisory/Advisory | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Advisory/Advisory | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory | 2a6ee9dd-b3bf-47a6-ab76-a426c6421b3f | BDO.ServiceArea |
| /Advisory/Advisory | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /Advisory/Advisory | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Advisory/Advisory | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Advisory/Advisory | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Advisory/Advisory | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory | 2a6ee9dd-b3bf-47a6-ab76-a426c6421b3f | BDO.ServiceArea |
| /Advisory/Advisory | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /Advisory/BDO-Consulting | 0cec9a62-cc4e-4ba6-b0f1-ae6c49136b48 | BDO.Industry |
| /Advisory/BDO-Consulting | 03b7bec7-c64a-4c27-9ff5-7074260b1ad0 | BDO.Industry |
| /საქართველოში/Demo-Business-line | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | dea19c24-7a9a-4c58-aa47-819e262884ef | — |
| /საქართველოში/MV-Business-Line | 4bd7f822-b92a-4a4d-b5f8-3259b954b60e | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | c9969cd9-e981-452c-87af-2ef7dcf4f1a0 | BDO.ThankYouConversionPages |
| /საქართველოში/MV-Business-Line | 772c0163-13e5-41a7-ade3-0413c0f149cf | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /საქართველოში/MV-Business-Line | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Secured-Business-Line | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (24 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Sustainability-and-ESG | 772c0163-13e5-41a7-ade3-0413c0f149cf | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 4f5d04d2-f99c-4784-b59a-8c69a2588191 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 4f5d04d2-f99c-4784-b59a-8c69a2588191 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 05f6605d-b2d9-4215-b73a-4e20caafa5b0 | BDO.IndustryService |
| /საქართველოში/BDO-Digital | 1335ccb6-b455-4f12-b638-cf39b6687203 | BDO.Industry |
| /საქართველოში/BDO-Digital | 74ed8b0b-b95b-4c36-b382-f03cc087b767 | BDO.Industry |
| /საქართველოში/Hellou | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /საქართველოში/Hellou | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/Hellou | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line | f69fc4c4-b8e7-4939-a8ff-8c528834b406 | BDO.ServiceArea |
| /საქართველოში/Demo-Business-line | c60d3116-96d6-48ab-b95d-9ff037ebeff2 | BDO.ServiceArea |
| /საქართველოში/Demo-Business-line | debab297-5bd7-465c-9543-4d5bbaa86796 | BDO.ServiceArea |
| /საქართველოში/Demo-Business-line | ddff9311-4ee2-456e-94b4-e1f58947190e | BDO.ServiceArea |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (48 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory | 314c0324-e0a7-4da1-8eaf-2f5539f26f13 | BDO.BusinessLine |
| /Advisory/Advisory | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Advisory/Advisory | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Advisory/Advisory | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Advisory/Advisory | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory | 2a6ee9dd-b3bf-47a6-ab76-a426c6421b3f | BDO.ServiceArea |
| /Advisory/Advisory | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /Advisory/Advisory | 314c0324-e0a7-4da1-8eaf-2f5539f26f13 | BDO.BusinessLine |
| /Advisory/Advisory | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Advisory/Advisory | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Advisory/Advisory | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Advisory/Advisory | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory | 2a6ee9dd-b3bf-47a6-ab76-a426c6421b3f | BDO.ServiceArea |
| /Advisory/Advisory | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /Advisory/Advisory | 314c0324-e0a7-4da1-8eaf-2f5539f26f13 | BDO.BusinessLine |
| /Advisory/Advisory | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Advisory/Advisory | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Advisory/Advisory | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Advisory/Advisory | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory | 2a6ee9dd-b3bf-47a6-ab76-a426c6421b3f | BDO.ServiceArea |
| /Advisory/Advisory | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /საქართველოში/Lape-Business-Line | 5b10cce0-6eeb-4a6a-a3bc-623834c4a176 | BDO.MicrositeMasterPage |
| /საქართველოში/Lape-Business-Line | 5480f5b8-4267-4877-b209-f941be4cc6db | — |
| /საქართველოში/Lape-Business-Line | 10d8575b-72e2-4497-9083-4795270a408b | BDO.MicrositePage |
| /საქართველოში/Lape-Business-Line | ca5112a2-8400-4b23-bdf1-96ff947be8ef | BDO.MicrositePage |
| /საქართველოში/Lape-Business-Line | 52b744bd-6c2e-47ab-b137-931281b8ec31 | BDO.MicrositePage |
| /საქართველოში/Lape-Business-Line | 5bbc25dd-b0da-4952-99c0-bcb52125147d | BDO.MicrositePage |
| /საქართველოში/Lape-Business-Line | 7ec96890-fff8-46b4-8f6d-9aa875cc2958 | BDO.Insight |
| /საქართველოში/Lape-Business-Line | 8a715321-ebc9-47ef-a5ba-6f4be78b852f | BDO.Insight |
| /საქართველოში/Advisory | 8413ab13-9726-47e2-b721-15d29fd91297 | BDO.BusinessLine |
| /საქართველოში/Advisory | 1598c894-73f7-4919-9e39-109a9632e6f0 | BDO.BusinessLine |
| /საქართველოში/Advisory | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /საქართველოში/Advisory | 2b495eed-170a-4ee3-bf34-d3c0de775631 | BDO.MicrositePage |
| /საქართველოში/Advisory | 597e9fef-7ce4-4049-a9ec-52da99ce456e | BDO.MicrositePage |
| /საქართველოში/Advisory | 0349003c-7a6c-4feb-9ef1-082ae7039906 | BDO.MicrositePage |
| /საქართველოში/Hellou | 482706ac-88db-4ff0-9005-a064129968fb | BDO.MicrositePage |
| /საქართველოში/Hellou | e9d3e97c-6283-4729-93ca-c5cf07cdea47 | BDO.MicrositePage |
| /საქართველოში/Hellou | 784869f1-f470-425d-87b4-205f4c9c24b9 | BDO.MicrositePage |
| /საქართველოში/Hellou | 4a3f91fc-6fe3-4c57-beed-3ac568dd2803 | BDO.MicrositePage |
| /საქართველოში/Hellou | c3f5b515-b460-4812-aef3-224756dd63f7 | BDO.BlogContributors |
| /საქართველოში/Hellou | a1d012b5-4611-4234-abc8-23cdacaad082 | BDO.Blog |
| /საქართველოში/Hellou | cc643605-70f1-4005-924d-3396573339e6 | BDO.Blog |
| /საქართველოში/Consulting-Unternehmensberatung | ee0e92ed-d0b0-49da-b35b-5a914bed3bc4 | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung | 3dd47f86-0ac8-40bf-97c3-2ec548b1a0e0 | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung | fea16a74-f481-4b0f-878c-5e01a345f02e | BDO.Insight |
| /საქართველოში/Demo-Business-line | fb30884d-91a8-4222-974f-6d50758f25c3 | BDO.Insight |
| /საქართველოში/Demo-Business-line | 12549a84-7817-4d0d-8dbd-eb2b50774b19 | BDO.Insight |
| /საქართველოში/Demo-Business-line | a1dbbb85-7be2-49ff-95ff-ae36fdec47ab | BDO.Insight |

#### BDO.BusinessStrategy

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies/Business-Strategy-Category/Das-Hinweisgeberschutzgesetz-ist-da! | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `featuredEventsAndWebinars` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies/Business-Strategy-Category/Evolve-Your-Operation | b2d68195-5e8a-4852-8bde-75821c4c722d | BDO.Webinar |
| /Business-Strategies/Business-Strategy-Category/Evolve-Your-Operation | f9e76caf-b7f6-4f61-a39a-15e2f5673ca3 | BDO.Event |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies/Business-Strategy-Category/Business-Strategy | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies/Business-Strategy-Category/Business-Strategy | 01576354-9d31-41d4-9cea-94ab15971c1c | — |
| /Business-Strategies/Business-Strategy-Category/Business-Strategy | c8b2d233-8cef-4916-8fe6-d9d4a14d86b9 | BDO.Insight |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (5 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-strategies/Business-Strategy | 03b7bec7-c64a-4c27-9ff5-7074260b1ad0 | BDO.Industry |
| /Business-strategies/Business-Strategy | 0cec9a62-cc4e-4ba6-b0f1-ae6c49136b48 | BDO.Industry |
| /Business-strategies/Business-Strategy | e4d57642-e0e5-45c5-a323-be8fda5d2c01 | BDO.IndustryService |
| /Business-Strategies/Category-2/New-Business-Strategy | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /Business-Strategies/Category-2/New-Business-Strategy | 358bfd5b-434b-405b-bc63-53b59f3dd8c6 | BDO.Industry |

#### BDO.Career

##### Page Type Field References

**property `CareerApplyForm`** — ObjectSelector (10 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Job-opportunities/Junior-IT-Specialist | — | — |
| /Careers/Job-opportunities/Solution-Architect | — | — |
| /Careers/Job-opportunities/Looking-for-a-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Looking-for-Another-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Free-Compliance-Officer-Position | — | — |
| /Careers/Job-opportunities/QA-Tester | — | — |
| /Careers/Job-Opportunities/Mesijas | — | — |
| /Careers/Test-Search/Testing-API-EV1-title | — | — |
| /Careers/Test-Search/test-career | — | — |
| /Careers/Test-Search/career-2 | — | — |

##### Page Type Field References

**property `CareerEmploymentType`** — PageTypeField (10 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Job-opportunities/Junior-IT-Specialist | — | — |
| /Careers/Job-opportunities/Solution-Architect | — | — |
| /Careers/Job-opportunities/Looking-for-a-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Looking-for-Another-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Free-Compliance-Officer-Position | — | — |
| /Careers/Job-opportunities/QA-Tester | — | — |
| /Careers/Job-Opportunities/Mesijas | — | — |
| /Careers/Test-Search/Testing-API-EV1-title | — | — |
| /Careers/Test-Search/test-career | — | — |
| /Careers/Test-Search/career-2 | — | — |

##### Page Type Field References

**property `CareerJobTitle`** — PageTypeField (10 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Job-opportunities/Junior-IT-Specialist | — | — |
| /Careers/Job-opportunities/Solution-Architect | — | — |
| /Careers/Job-opportunities/Looking-for-a-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Looking-for-Another-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Free-Compliance-Officer-Position | — | — |
| /Careers/Job-opportunities/QA-Tester | — | — |
| /Careers/Job-Opportunities/Mesijas | — | — |
| /Careers/Test-Search/Testing-API-EV1-title | — | — |
| /Careers/Test-Search/test-career | — | — |
| /Careers/Test-Search/career-2 | — | — |

##### Page Type Field References

**property `CareerLevel`** — PageTypeField (10 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Job-opportunities/Junior-IT-Specialist | — | — |
| /Careers/Job-opportunities/Solution-Architect | — | — |
| /Careers/Job-opportunities/Looking-for-a-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Looking-for-Another-Chartered-Accountant | — | — |
| /Careers/Job-opportunities/Free-Compliance-Officer-Position | — | — |
| /Careers/Job-opportunities/QA-Tester | — | — |
| /Careers/Job-Opportunities/Mesijas | — | — |
| /Careers/Test-Search/Testing-API-EV1-title | — | — |
| /Careers/Test-Search/test-career | — | — |
| /Careers/Test-Search/career-2 | — | — |

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Job-Opportunities/SR-QA-TESTER | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |
| /Careers/Test-Search/test-career | c36e2863-d03e-4e75-b91b-fda3b7bcb62f | _(media file)_ |

#### BDO.CareerCategory

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Junior-Specialists | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |
| /Careers/Junior-QA | 6d7d160a-fc7a-44e9-889f-febe35297665 | _(media file)_ |

#### BDO.CareerContent

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `featuredEventsAndWebinars` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers/Career-Category-Internships/Career-Content-QA-Internship | 4c09ad92-7a5e-44d8-af13-0cb7ea8152d2 | BDO.Webinar |
| /Careers/Career-Category-Internships/Career-Content-QA-Internship | 89534182-b6f5-4d9f-8797-b0ec1319c012 | BDO.Event |
| /Careers/Career-Category-Internships/Career-Content-QA-Internship | 371dfa0b-3366-4d32-8d53-33f1621e3f03 | BDO.Webinar |
| /Careers/Career-Category-Internships/Career-Content-QA-Internship | d452bc7f-e57b-4000-9e12-910e074f5281 | BDO.Webinar |

#### BDO.Contact

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Contact-us | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

#### BDO.Deal

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/Cleo-Diagnostics-Limited-completes-its-listing-of | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/MV-Deal-LT | 0a20bda0-71b1-4868-956d-6acc014873cb | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/MV-Deal-LT | 45e0c1ca-b005-4dab-99ef-55f951424912 | BDO.HomeHeroSlide |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/Deal-MV | 068dd235-81cb-416b-9003-6c7cb6dceeae | BDO.Person |
| /Deals/Deal-2015 | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |
| /Deals/Deal-2015 | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |
| /Deals/Deal-2015 | c5f0ad09-48c0-4b5b-a50c-ead79ebd9b36 | BDO.Person |
| /Deals/New-Deal-EV | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /Deals/JJ-Deal-(1)/JJ-Deal-12-June-2025 | c5f0ad09-48c0-4b5b-a50c-ead79ebd9b36 | BDO.Person |
| /Deals/JJ-Deal-(1)/JJ-Deal-12-June-2025 | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |
| /Deals/JJ-Deal-(1)/JJ-Deal-12-June-2025 | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/MV-Deal-LT | 1aaf55ba-e9c0-4f6b-aeb6-9fdc3c3db73b | BDO.Industry |
| /Deals/MV-Deal-LT | ef5fe694-b8ea-47bf-9fb9-34b74e2acef6 | BDO.Industry |
| /Deals/MV-Deal-LT | a349e414-a135-4b20-85ae-0ff845e32e7e | BDO.IndustryService |
| /Deals/MV-Deal-LT | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /Deals/MV-Deal-LT | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /Deals/MV-Deal-LT | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/MV-Deal-LT-checked-in | 83d259b0-dd51-4d9c-9f60-9aa351da0954 | BDO.Blog |

#### BDO.Event

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Events/Test-1 | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |
| /Events/Event-A-6 | 890ec1d7-5d2a-4375-8141-6d18a8692924 | _(media file)_ |
| /Events/Event-A-12 | a1796b34-5c81-4766-8c6a-13c4c8cfd1af | _(media file)_ |
| /Events/Event-A-14 | 75f0f0cd-83bb-4447-a8d8-8c2dbc8edc59 | _(media file)_ |

#### BDO.HomeHeroSlide

##### Page Type Field References

**property `Image_Mobile`** — MediaFilesSelector (5 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home-page/Curabitur-augue-quam,-feugiat-vel-dolor-quis,-maxi | 3887998c-9b04-4725-99e3-3a1ee7d9c447 | _(media file)_ |
| /Homepage/Home-hero-slide-1 | b263ad01-a9bf-4ee2-bf24-21c971877e51 | _(media file)_ |
| /Homepage/When-Life-Gives-You-Lemons | a7d408b7-ab79-41bc-8ab6-c1c56c312dab | _(media file)_ |
| /Homepage/Hero-slide-1 | 4d34a87c-eace-4b8c-bac2-c07a24ce4305 | _(media file)_ |
| /Homepage/Hero-slide-1 | 4d34a87c-eace-4b8c-bac2-c07a24ce4305 | _(media file)_ |

##### Page Type Field References

**property `Image_Thumbnail`** — MediaFilesSelector (5 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home-page/Curabitur-augue-quam,-feugiat-vel-dolor-quis,-maxi | 1790d01d-f8a6-490d-b962-84ee1fff8776 | _(media file)_ |
| /Homepage/Home-hero-slide-1 | 223fda22-9851-4a8c-8a0b-271087461f80 | _(media file)_ |
| /Homepage/When-Life-Gives-You-Lemons | 1539e224-f0cc-41ce-b106-490d804c2eb0 | _(media file)_ |
| /Homepage/Hero-slide-1 | 8341f62e-e7b2-4385-b936-4dc6c1508343 | _(media file)_ |
| /Homepage/Hero-slide-1 | 8341f62e-e7b2-4385-b936-4dc6c1508343 | _(media file)_ |

#### BDO.HomePage

##### Page Type Field References

**property `MetadataOGImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home-page | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home-page | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Homepage | c2e1e8c3-aabe-46ad-b5dc-b44489f21073 | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home | f1fdc4a0-de3a-46d6-9e33-2cc2647d3e76 | _(media file)_ |
| /Homepage | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Homepage-2 | ceecd594-c1da-421d-8633-39acd1ff1d09 | BDO.Insight |
| /Homepage-2 | 8a7c57bb-4cad-4452-bc92-124f138ca522 | BDO.Insight |
| /Homepage | f3fc6785-7833-42ec-bc0c-183f2020eb0b | BDO.Insight |

##### Widget References

**`BDO.Widget.NewsCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Homepage | c2e1e8c3-aabe-46ad-b5dc-b44489f21073 | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home | f1fdc4a0-de3a-46d6-9e33-2cc2647d3e76 | _(media file)_ |
| /Homepage | a893cb83-97b4-4380-80f0-f7d08fbef3b6 | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (19 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Home | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Home | b58aa369-5dbd-40de-b73e-909929e40111 | BDO.Insight |
| /Home | fa8f6343-64cb-41a6-8075-f86ef92edd61 | BDO.Insight |
| /Home | cea5dd54-afbe-4b9a-8c2a-ec35f7db1a23 | BDO.Insight |
| /Home | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Home | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Home | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Home | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Home | 0cec9a62-cc4e-4ba6-b0f1-ae6c49136b48 | BDO.Industry |
| /Home | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |
| /Home | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Home | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Home | 2e50de6e-2153-47fa-892d-433974be708b | BDO.ServiceArea |
| /Home | 4fd34524-c513-42a7-a968-2e20bb837c72 | BDO.ServiceArea |
| /Home | 923d2d64-01a2-40bd-a14e-45b321f9cbd0 | BDO.SectionInsightsPage |
| /Homepage | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /Homepage | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |
| /Homepage | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /Homepage | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |

#### BDO.Industry

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Financial-Services/zzz-industry | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Consumer-Services/Delivery-Services | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Industries/Consumer-Services/Delivery-Services | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Industries/Consumer-Services/Delivery-Services | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Industries/Consumer-Services/Delivery-Services | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |

##### Widget References

**`BDO.Widget.RelatedContentCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/RK-Category-1/RK-Industry | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Automotive/Industry | c60d3116-96d6-48ab-b95d-9ff037ebeff2 | BDO.ServiceArea |
| /Industries/Automotive/Industry | 236c6521-7197-448e-84e5-647b57c11e50 | BDO.Service |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/RK-Category-1/RK-Industry | e27038ec-257c-4358-a804-5864a614bbe4 | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/RK-Category-1/RK-Industry | 14adf4a9-d352-4cdb-b71a-049561bbd840 | BDO.Industry |
| /Industries/RK-Category-1/RK-Industry | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /Industries/RK-Category-1/RK-Industry | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /Industries/RK-Category-1/RK-Industry | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Consumer-Services/Delivery-Services | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /Industries/Consumer-Services/Delivery-Services | 4cba45dd-8e8b-4352-ae02-5f5f8daf9635 | — |
| /Industries/Consumer-Services/Delivery-Services | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |

#### BDO.IndustryCategory

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Private-Equity | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Professional-services | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (9 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Professional-services | af9fc8e5-2079-493e-aab1-2ccbe7833c2a | BDO.BusinessLine |
| /Industries/Professional-services | ae17675f-600d-4427-8d8f-913d302730fb | BDO.BusinessLine |
| /Industries/Professional-services | ede5b8dc-66fe-4cc6-ac71-c94f7536217a | BDO.BusinessLine |
| /Industries/Professional-services | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /Industries/Professional-services | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /Industries/Professional-services | c60d3116-96d6-48ab-b95d-9ff037ebeff2 | BDO.ServiceArea |
| /Industries/Professional-services | ce3a574b-0a09-4785-8e21-71b81f97336a | BDO.ServiceArea |
| /Industries/Professional-services | c5715a3e-0f24-4790-9f75-c7f94fb2f095 | BDO.ServiceArea |
| /Industries/Professional-services | d80d4ff3-cc26-420a-8afd-0daa816a4767 | BDO.ServiceArea |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Lape-Industries | ff59444a-831a-4d40-a5fe-238e77669821 | _(media file)_ |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `featuredPages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Real-Estate-Construction | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /Industries/Real-Estate-Construction | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (10 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Financial-Services | fd92ce94-3cd6-4c9f-a2e5-d78a0b5c5e17 | BDO.Insight |
| /Industries/Financial-Services | 62ab34a6-3b70-4af1-8018-19cfdaa24d8f | BDO.Insight |
| /Industries/Financial-Services | 688e34b6-c6a4-4af3-9ec6-7681e77fd2d1 | BDO.Deal |
| /Industries/Financial-Services | adb37c82-4549-4b72-adf2-517b6532069c | BDO.Deal |
| /Industries/Real-Estate-Construction | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /Industries/Real-Estate-Construction | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /Industries/Real-Estate-Construction | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /Industries/Real-Estate-Construction | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /Industries/Real-Estate-Construction | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /Industries/Real-Estate-Construction | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Lape-Industries | ff59444a-831a-4d40-a5fe-238e77669821 | _(media file)_ |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Consumer-Services | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Industries/Consumer-Services | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Industries/RK-Category-1 | ebbdb5cd-bf88-4187-9abb-f7f1c9ccad5f | BDO.Person |
| /Industries/RK-Category-1 | e83ab225-caaf-426f-8707-01a88c166690 | BDO.Person |
| /Industries/RK-Category-1 | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |
| /Industries/RK-Category-1 | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (33 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Automotive | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /Industries/Automotive | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |
| /Industries/Real-Estate-Construction | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /Industries/Real-Estate-Construction | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /Industries/Real-Estate-Construction | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /Industries/Real-Estate-Construction | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |
| /Industries/Real-Estate-Construction | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /Industries/Real-Estate-Construction | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /Industries/Private-Equity | c9969cd9-e981-452c-87af-2ef7dcf4f1a0 | BDO.ThankYouConversionPages |
| /Industries/Private-Equity | 772c0163-13e5-41a7-ade3-0413c0f149cf | BDO.IndustryCategory |
| /Industries/Private-Equity | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /Industries/Private-Equity | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /Industries/Private-Equity | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /Industries/Private-Equity | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /Industries/Private-Equity | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /Industries/Private-Equity | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /Industries/Private-Equity | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /Industries/Private-Equity | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /Industries/Private-Equity | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /Industries/Private-Equity | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |
| /Industries/Private-Equity | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /Industries/Private-Equity | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /Industries/Private-Equity | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /Industries/Private-Equity | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /Industries/Shipping-and-Transport | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |
| /Industries/Test | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /Industries/RK-Category-1 | 772c0163-13e5-41a7-ade3-0413c0f149cf | BDO.IndustryCategory |
| /Industries/RK-Category-1 | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /Industries/RK-Category-1 | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /Industries/RK-Category-1 | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /Industries/RK-Category-1 | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /Industries/RK-Category-1 | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/RK-Category-1 | 5b390699-9161-4fa5-8919-3975bbce843d | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/RK-Category-1 | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /Industries/RK-Category-1 | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /Industries/RK-Category-1 | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /Industries/RK-Category-1 | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (21 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Financial-Services | ceecd594-c1da-421d-8633-39acd1ff1d09 | BDO.Insight |
| /Industries/Financial-Services | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Industries/Financial-Services | b58aa369-5dbd-40de-b73e-909929e40111 | BDO.Insight |
| /Industries/Financial-Services | 0f32d6f7-dcf2-4c8e-a0cc-f7f40e43b043 | BDO.Insight |
| /Industries/Shipping-and-Transport | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |
| /Industries/Test | 780b9e8b-b33f-486b-af21-81994d941788 | BDO.Insight |
| /Industries/Test | e6619801-d131-4884-8621-7057df2b8d33 | BDO.Insight |
| /Industries/Test | 00872476-11b4-4c43-aac1-e091f8c8e886 | BDO.Insight |
| /Industries/Test | 9d543512-0897-4df6-8daf-ecae71210e4e | BDO.Insight |
| /Industries/Test | 780b9e8b-b33f-486b-af21-81994d941788 | BDO.Insight |
| /Industries/Test | e6619801-d131-4884-8621-7057df2b8d33 | BDO.Insight |
| /Industries/Test | 00872476-11b4-4c43-aac1-e091f8c8e886 | BDO.Insight |
| /Industries/Test | 9d543512-0897-4df6-8daf-ecae71210e4e | BDO.Insight |
| /Industries/Lape-Industries | beb65c42-85fa-4de9-b948-e7429f9a247d | BDO.Blog |
| /Industries/Lape-Industries | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |

#### BDO.IndustryService

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Consumer-Services/Delivery-Services/Industry-Service | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Industries/Consumer-Services/Delivery-Services/Industry-Service | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Industries/Consumer-Services/Delivery-Services/Industry-Service | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Industries/Consumer-Services/Delivery-Services/Industry-Service | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (7 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /Industries/Shipping-and-Transport/Industry-1-child/RK-industry-service-2 | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |

#### BDO.Insight

##### Page Type Field References

**property `DownloadButtonAttachment`** — MediaFilesSelector (13 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Art-and-Culture-2023-2024 | 73ae8641-c77c-4f78-aba7-a2119269c477 | _(media file)_ |
| /Insights/Art-and-Culture-2023-2024-(1) | 43e16982-5eac-4ffc-8438-3dcf9f1477e1 | _(media file)_ |
| /Insights/Demo-Insight-without-sidebar | 43e16982-5eac-4ffc-8438-3dcf9f1477e1 | _(media file)_ |
| /Insights/Demo-Insight-without-sidebar-(1) | 43e16982-5eac-4ffc-8438-3dcf9f1477e1 | _(media file)_ |
| /Insights/New-Layout-Demo-Insight | a840f38b-f513-47db-8b03-e928aa102770 | _(media file)_ |
| /Insights/Industry-Updates-A-2025-Perspective | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |
| /Insights/Exploring-possibilities-in-Finance-AI-and-Machine | 36739f40-8b2c-4356-949c-f9668f5946e4 | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Article | 73ae8641-c77c-4f78-aba7-a2119269c477 | _(media file)_ |
| /Insights/JJ-Insight-category/No-Sidebar-Insight-Page-2 | 20f3b1d4-6377-4bf2-a49c-8f7974c6e9be | _(media file)_ |
| /Insights/Matas-Quote-demo | 20cd3a89-7028-4881-87b6-fd5de7db1bb2 | _(media file)_ |
| /Insights/EV-GWT-article-4-(1) | e21a8e94-cb15-48ba-8965-01e03492de4c | _(media file)_ |
| /Insights/EV-GWT-article-6 | c2e1e8c3-aabe-46ad-b5dc-b44489f21073 | _(media file)_ |
| /Insights/Matas-Quote-demo-(1) | 20cd3a89-7028-4881-87b6-fd5de7db1bb2 | _(media file)_ |

##### Page Type Field References

**property `Image`** — MediaFilesSelector (84 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In | 36739f40-8b2c-4356-949c-f9668f5946e4 | _(media file)_ |
| /Insights/Art-and-Culture-2023-2024 | cf3b12ba-25f0-4b65-92a7-0a66dbcc403c | _(media file)_ |
| /Insights/Art-and-Culture-2023-2024-(1) | cf3b12ba-25f0-4b65-92a7-0a66dbcc403c | _(media file)_ |
| /Insights/Demo-Insight-without-sidebar | d9ec4e9e-2d08-4b50-9845-fe24c0f7f729 | _(media file)_ |
| /Insights/Demo-Insight-without-sidebar-(1) | d9ec4e9e-2d08-4b50-9845-fe24c0f7f729 | _(media file)_ |
| /Insights/New-Layout-Demo-Insight | a840f38b-f513-47db-8b03-e928aa102770 | _(media file)_ |
| /Insights/Matas-Quote-demo | b5fb74cb-6b00-414e-b4ed-badb61fc519d | _(media file)_ |
| /Insights/Industry-Updates-A-2025-Perspective | 2492e91b-08c4-497f-83d6-f9bc01367ea4 | _(media file)_ |
| /Insights/Exploring-possibilities-in-Finance-AI-and-Machine | 36739f40-8b2c-4356-949c-f9668f5946e4 | _(media file)_ |
| /Insights/Matas-Contributors-Demo | 38f03f6c-2f18-4415-ba41-43af55446dec | _(media file)_ |
| /Insights/Demo-Sections | d9ec4e9e-2d08-4b50-9845-fe24c0f7f729 | _(media file)_ |
| /Insights/Demo-Widgets | b5fb74cb-6b00-414e-b4ed-badb61fc519d | _(media file)_ |
| /Insights/Matas-Demo | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Insights/Matas-Demo-(1) | a840f38b-f513-47db-8b03-e928aa102770 | _(media file)_ |
| /Insights/Key-takeaways-demo | 58729201-ba36-4dea-b62e-53d8b0e97ce6 | _(media file)_ |
| /Insights/Insight-with-hero | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Section-Insights/Audit/E2E-Insight | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |
| /Section-Insights/E2E-Automated-Insight-Category/694863-E2E_Insight | a1796b34-5c81-4766-8c6a-13c4c8cfd1af | _(media file)_ |
| /Insights/After-change-test | 1acf11db-c48a-411f-831a-89ce3b94f984 | _(media file)_ |
| /Insights/Dev-insight | 7f9d8fa1-1eb2-4ad7-a954-f1ffcb63f10d | _(media file)_ |
| /Insights/After-change-test-(1) | 4c6314be-d650-4834-bd29-c5c6f5ff77a6 | _(media file)_ |
| /Insights/After-change-test-(2) | 31ed501f-985c-47a5-b1f4-9d9369dc5280 | _(media file)_ |
| /Insights/DEV-Site-for-BCR-2 | 62d8d4e5-1f4e-479c-8219-65266d44fa03 | _(media file)_ |
| /Insights/DEV-Site-for-BCR-2-(1) | 3e731ee6-17e6-484f-a5aa-c77a0d16fddd | _(media file)_ |
| /Insights/EV-GWT-article-4 | bc099ed2-2f19-4d15-8e15-c4dc7ea07ad8 | _(media file)_ |
| /Insights/Hotfix-195 | af970d85-1aa7-49cf-a864-7c6e44e9074d | _(media file)_ |
| /Section-insights/Insight | 58729201-ba36-4dea-b62e-53d8b0e97ce6 | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/No-sidebar-Insight | 29e64bca-763e-4fd8-a365-f40965063bda | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/Insight-to-test-RSS | 06d2379c-1b29-4a85-83a1-3e6c30f69fce | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-to-test-embeded-content | d9ec4e9e-2d08-4b50-9845-fe24c0f7f729 | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-New-Insight-no-modifications | a27311e2-c034-427d-ab8f-5d8c4a35e837 | _(media file)_ |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | 29e64bca-763e-4fd8-a365-f40965063bda | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Article | b5fb74cb-6b00-414e-b4ed-badb61fc519d | _(media file)_ |
| /Insights/JJ-Insight-category/Insight-without-structured-content | b5fb74cb-6b00-414e-b4ed-badb61fc519d | _(media file)_ |
| /Insights/JJ-Insight-category/Reports-Horizon | 729d93a9-5726-402f-a9ec-05dc356a7536 | _(media file)_ |
| /Insights/JJ-Insight-category/No-Sidebar-Insight-Page-2 | 2799d42a-c3c8-4171-955f-510255282c8b | _(media file)_ |
| /Insights/Insight-Category-EV/EV-Insight | d90d99a5-5165-45da-9c40-b02d66218c11 | _(media file)_ |
| /Insights/!Insight-category/Koub-af-unoterede-aktier-for-pensionsmidler | 64dd6c4d-fd76-4905-bcd8-77a2e875faf5 | _(media file)_ |
| /Insights/Insight-to-publish-in-the-future | ff59444a-831a-4d40-a5fe-238e77669821 | _(media file)_ |
| /Insights/After-change-test | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |
| /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(2) | 530434da-5506-4299-8c1e-a1085bcb07b3 | _(media file)_ |
| /Insights/Lukas-Testing-(3) | 211ce4b2-4e87-4055-a469-45431fddaf7c | _(media file)_ |
| /Insights/Insight-from-future1 | b60706c4-9dfb-4efd-9e16-8cfcea7863eb | _(media file)_ |
| /Insights/After-change-test-(1)-Changed | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |
| /Insights/After-hiding | c2e1e8c3-aabe-46ad-b5dc-b44489f21073 | _(media file)_ |
| /Insights/DEV-Site-for-BCR-2-(3) | 49c4ad20-0a96-4222-a4e1-c61dd87e9660 | _(media file)_ |
| /Insights/Test-creation-of-new-Insight-(1) | 10ef2da9-9657-47e0-90d5-780659c2cff1 | _(media file)_ |
| /Insights/My-test-22 | b60706c4-9dfb-4efd-9e16-8cfcea7863eb | _(media file)_ |
| /Insights/Insight-to-test-copied-insights | 890ec1d7-5d2a-4375-8141-6d18a8692924 | _(media file)_ |
| /Insights/Hikaruuuu-(1) | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |
| /Insights/2023-Automotive-Year-End-Tax-Bulletin-(1) | a2845679-523c-473f-8ea2-f59c93694645 | _(media file)_ |
| /Insights/Insighast-(1)2 | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |
| /Insights/My-test-22-(1) | b60706c4-9dfb-4efd-9e16-8cfcea7863eb | _(media file)_ |
| /Insights/Insight-with-default-container | 3b54ef30-3d97-4ddf-bd69-f5606d166797 | _(media file)_ |
| /Insights/Insight-with-default-container-(1) | 3b54ef30-3d97-4ddf-bd69-f5606d166797 | _(media file)_ |
| /Insights/E2E_Insight_Category_Automated/694863_E2E_Insight | 7b20b484-88a1-45b4-a422-d9f0137e4323 | _(media file)_ |
| /Insights/IT-Compliance/BDO-Leitfaden-zu-europaischen-Technologievorschrif | 87775ebc-cd96-43ff-91f0-f4ddf8635253 | _(media file)_ |
| /Insights/IT-Compliance/Julegave-fra-arbeidsgiver-skattefritt-eller-skatte | 1e7695fe-78da-496a-a017-da631237c9f8 | _(media file)_ |
| /Insights/Insight-Page-Title-H1 | 29e64bca-763e-4fd8-a365-f40965063bda | _(media file)_ |
| /Insights/Characters-test-oe-ss-ou | f7d102eb-7a4b-432f-ae95-6e56fd435290 | _(media file)_ |
| /Insights/Julegave-fra-arbeidsgiver-skattefritt-eller | 729d93a9-5726-402f-a9ec-05dc356a7536 | _(media file)_ |
| /Insights/מיסים/מבזקי-מס/2022-היערכות-לקראת-סוף-שנת-המס | be65a507-520d-4f7c-9c5e-6bfe0fb42741 | _(media file)_ |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | a109f994-3749-4d9c-b089-5c09080a03d6 | _(media file)_ |
| /Insights/Test-Ondemand-event | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |
| /Insights/EV-API-Test-1 | 29e64bca-763e-4fd8-a365-f40965063bda | _(media file)_ |
| /Insights/Test-creation-of-new-Insight-(2) | 10ef2da9-9657-47e0-90d5-780659c2cff1 | _(media file)_ |
| /Insights/Test-Ali | 890ec1d7-5d2a-4375-8141-6d18a8692924 | _(media file)_ |
| /Insights/New-insight-for-CR-testing-(2) | 91ae4f6a-0918-49a1-8442-059bcffb5e57 | _(media file)_ |
| /Insights/EV-GWT-article-4 | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |
| /Insights/Matas-Quote-demo | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Insights/EV-GWT-article-4-(1) | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |
| /Insights/EV-GWT-article-6 | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |
| /Insights/MV-insight-category/Reports-Horizon | 729d93a9-5726-402f-a9ec-05dc356a7536 | _(media file)_ |
| /Insights/MV-insight-category/Insight-with-hero | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Insights/EV-GWT-article-7 | 96b261cb-d414-4f46-92ed-8180de22cd90 | _(media file)_ |
| /Insights/EV-GWT-Article-8 | 70a16726-abd3-482b-99a5-0996e3dce956 | _(media file)_ |
| /Insights/EV-GWT-article-9 | 70a16726-abd3-482b-99a5-0996e3dce956 | _(media file)_ |
| /Insights/test-one-two | 396469eb-50ee-4f4f-8a97-d7ad1591b079 | _(media file)_ |
| /Insights/EV-GWT-Article-10 | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Insights/JJ-New-Insight-no-modifications | a27311e2-c034-427d-ab8f-5d8c4a35e837 | _(media file)_ |
| /Insights/Matas-Quote-demo-(1) | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Insights/Insight | 58729201-ba36-4dea-b62e-53d8b0e97ce6 | _(media file)_ |
| /Insights/JJ-New-Insight-no-modifications-(1) | a27311e2-c034-427d-ab8f-5d8c4a35e837 | _(media file)_ |
| /Insights/After-change-test | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |

##### Page Type Field References

**property `MetadataOGImage`** — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/JJ-Insight-category/JJ-Article | b5fb74cb-6b00-414e-b4ed-badb61fc519d | _(media file)_ |
| /Insights/EV-GWT-article-4 | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (19 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/IFRB-2024-02-Amendments-to-IAS-1-–-Clarification-o | d97544ec-cc72-4d8c-b625-5dfd920b6d01 | _(media file)_ |
| /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-Affe | d97544ec-cc72-4d8c-b625-5dfd920b6d01 | _(media file)_ |
| /Insights/Art-and-Culture-2023-2024 | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |
| /Insights/Exploring-possibilities-in-Finance-AI-and-Machine | fdeeeb67-1bb7-4715-86ea-0c3721d598ef | _(media file)_ |
| /Section-Insights/Audit/E2E-Insight | 7b20b484-88a1-45b4-a422-d9f0137e4323 | _(media file)_ |
| /Section-Insights/E2E-Automated-Insight-Category/694863-E2E_Insight | 7b20b484-88a1-45b4-a422-d9f0137e4323 | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/No-sidebar-Insight | a109f994-3749-4d9c-b089-5c09080a03d6 | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/Insight-to-test-RSS | d9ec4e9e-2d08-4b50-9845-fe24c0f7f729 | _(media file)_ |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-to-test-embeded-content | d9ec4e9e-2d08-4b50-9845-fe24c0f7f729 | _(media file)_ |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | a109f994-3749-4d9c-b089-5c09080a03d6 | _(media file)_ |
| /Insights/Lape-Insight | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |
| /Insights/My-test-22-(1) | dcbacc5a-0ed9-423a-9dd6-4fea750a9a63 | _(media file)_ |
| /Insights/E2E_Insight_Category_Automated/694863_E2E_Insight | 7b20b484-88a1-45b4-a422-d9f0137e4323 | _(media file)_ |
| /Insights/EV-API-Test-1 | 36739f40-8b2c-4356-949c-f9668f5946e4 | _(media file)_ |
| /Insights/Matas-Quote-demo | a840f38b-f513-47db-8b03-e928aa102770 | _(media file)_ |
| /Insights/EV-GWT-article-6 | f04c6f25-78d6-4517-b51e-b15ca5abc03a | _(media file)_ |
| /Insights/EV-GWT-article-7 | 38f03f6c-2f18-4415-ba41-43af55446dec | _(media file)_ |
| /Insights/EV-GWT-Article-10 | 38f03f6c-2f18-4415-ba41-43af55446dec | _(media file)_ |
| /Insights/Matas-Quote-demo-(1) | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (7 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 9d543512-0897-4df6-8daf-ecae71210e4e | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 8e9b3c4b-25d1-4372-9c55-b67b41ef0c1c | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 8aeabd91-dceb-4072-b067-12e4a6013841 | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias | 02ad2bef-6fc8-4020-b35a-e372d5603760 | BDO.SectionInsightsPage |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias | 3dd47f86-0ac8-40bf-97c3-2ec548b1a0e0 | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias | feb2411a-ed6c-4a5a-bec5-4f7be0728635 | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias | a0a146bc-4d20-4a55-8bb4-1a29b1c9752a | BDO.Insight |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (29 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Industry-Updates-A-2025-Perspective | b0ae6e00-6105-4c0e-9b3d-2007a03fd8e1 | BDO.Event |
| /Insights/Industry-Updates-A-2025-Perspective | e05f067a-3ab2-4cf7-99a9-c3afc0566eea | BDO.Insight |
| /Insights/Industry-Updates-A-2025-Perspective | 1dcc8a96-dc6b-4e8a-88ec-9cbb7bf69aef | BDO.Insight |
| /Insights/Industry-Updates-A-2025-Perspective | ceecd594-c1da-421d-8633-39acd1ff1d09 | BDO.Insight |
| /Insights/Industry-Updates-A-2025-Perspective | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Insights/Demo-Widgets | 6ab7d515-5751-4094-94b6-3e3b4252f3ab | BDO.NewsArticle |
| /Insights/Demo-Widgets | 0edb60c6-63d0-4762-aa34-26ec2cd8b371 | BDO.NewsArticle |
| /Insights/Insight-with-hero | df8eea5c-2e97-41ef-8005-e0ea9cefe1ac | BDO.BlogPost |
| /Insights/Insight-with-hero | ea1e46b7-cfc6-472b-bf73-79fc8478578c | BDO.BlogPost |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias | 4eb28a4e-3095-4ffc-a96d-d9b20fb86dc0 | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/JJ-Insight-UpdatedAlias | 48c00e18-ab2d-4ef2-a89b-319dba2f21e7 | BDO.Insight |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | 8c262182-530d-43ec-b803-a08bbc7747a1 | BDO.NewsArticle |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | 40c55aca-dfe4-45a2-8430-24b9318436ad | BDO.NewsArticle |
| /Insights/DEV-Site-for-BCR-2-(3) | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /Insights/DEV-Site-for-BCR-2-(3) | d452bc7f-e57b-4000-9e12-910e074f5281 | BDO.Webinar |
| /Insights/EV-GWT-article-4 | 18f667e7-3aba-4186-bf1a-d8c0ed866968 | BDO.SectionEvents |
| /Insights/EV-GWT-article-4 | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /Insights/EV-GWT-article-4 | 2525a6f1-a806-4d59-848c-dec756735500 | BDO.Webinar |
| /Insights/EV-GWT-article-4 | 9416914d-fa23-4f86-8a6b-1ba353fea15f | BDO.EventRegistrationForm |
| /Insights/Matas-Quote-demo | 4604cd48-ed93-43cb-8531-71517d858ffb | BDO.Webinar |
| /Insights/Matas-Quote-demo | 9c545fb8-4179-4e97-a13b-2b20fcde418d | BDO.Webinar |
| /Insights/Matas-Quote-demo | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /Insights/EV-GWT-article-6 | 357d13de-9253-4c93-be4b-4186114f11b7 | BDO.Event |
| /Insights/EV-GWT-article-6 | 36537c45-2cde-4c55-8bdc-eee90e7be52d | BDO.Event |
| /Insights/EV-GWT-article-6 | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /Insights/EV-GWT-article-6 | 2525a6f1-a806-4d59-848c-dec756735500 | BDO.Webinar |
| /Insights/EV-GWT-article-6 | 4604cd48-ed93-43cb-8531-71517d858ffb | BDO.Webinar |
| /Insights/EV-GWT-article-6 | f1d26afc-8fb8-44cc-abbb-c2a1963df576 | BDO.Event |
| /Insights/EV-GWT-article-6 | 32337d94-b56a-4dd0-a211-a90fd83433d7 | BDO.Webinar |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `featuredEventsAndWebinars` — PageSelector (9 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 33c6d4b9-4719-41c6-a77f-5b8147f24510 | BDO.Webinar |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | e825a689-a4ed-4c57-b555-1fb2c5724f56 | BDO.Webinar |
| /Insights/DEV-Site-for-BCR | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR-2 | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR-2-(1) | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR-2-(2) | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR-2-(3) | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/EV-GWT-article-4 | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /Insights/EV-GWT-article-4 | 9416914d-fa23-4f86-8a6b-1ba353fea15f | BDO.EventRegistrationForm |

##### Widget References

**`BDO.Widget.Faq`** — property `pages` — PageSelector (19 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/IFRB-2024-02-Amendments-to-IAS-1-–-Clarification-o | c92db407-7b82-4247-922e-727483a60490 | BDO.FaqPage |
| /Insights/IFRB-2024-02-Amendments-to-IAS-1-–-Clarification-o | a7a7a512-8659-4ec2-acbf-952f68d312d3 | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 4f09d57f-6564-4b11-aa64-0868e9c808cc | BDO.FaqPage |
| /Insights/Key-takeaways-demo | f5946848-5676-4145-a315-4ea19635bb47 | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 140de78d-87af-4cc8-b9de-9d734c4d36a8 | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 60f197e3-0060-4cae-be28-396d96d6cb9e | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 140de78d-87af-4cc8-b9de-9d734c4d36a8 | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 60f197e3-0060-4cae-be28-396d96d6cb9e | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 4f09d57f-6564-4b11-aa64-0868e9c808cc | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 4f09d57f-6564-4b11-aa64-0868e9c808cc | BDO.FaqPage |
| /Insights/Key-takeaways-demo | f5946848-5676-4145-a315-4ea19635bb47 | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 140de78d-87af-4cc8-b9de-9d734c4d36a8 | BDO.FaqPage |
| /Insights/Key-takeaways-demo | 60f197e3-0060-4cae-be28-396d96d6cb9e | BDO.FaqPage |
| /Insights/EV-GWT-article-7 | 9f4cf1cf-96b0-4d15-9154-ce4360d8cd26 | BDO.FaqPage |
| /Insights/EV-GWT-article-7 | bf4a579e-7301-47b4-9574-9ae782e34e6f | BDO.FaqPage |
| /Insights/EV-GWT-article-7 | 89b4b5a7-eed5-4e36-85bf-f3b72672a547 | BDO.FaqPage |
| /Insights/EV-GWT-article-9 | aca8d771-124a-4f1c-9f83-034b69c5b0a1 | — |
| /Insights/EV-GWT-Article-10 | 9f4cf1cf-96b0-4d15-9154-ce4360d8cd26 | BDO.FaqPage |
| /Insights/Matas-Quote-demo-(1) | f7fd7940-2f17-464d-b197-4e91bec0e964 | BDO.FaqTopic |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (75 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Automotive-Sector-Update-Q4 | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Insights/Automotive-Sector-Update-Q4 | b58aa369-5dbd-40de-b73e-909929e40111 | BDO.Insight |
| /Insights/Automotive-Sector-Update-Q4 | fa8f6343-64cb-41a6-8075-f86ef92edd61 | BDO.Insight |
| /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In | 0a0e5db7-03eb-430c-acb1-d834a0ff7181 | BDO.Service |
| /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In | 631d0de0-d57a-4058-84e8-32ec89312e14 | BDO.ServiceArea |
| /Insights/Industry-Updates-A-2025-Perspective | 98037f94-3e6a-44a1-87d9-e2961ec2e824 | BDO.Insight |
| /Insights/Industry-Updates-A-2025-Perspective | ceecd594-c1da-421d-8633-39acd1ff1d09 | BDO.Insight |
| /Insights/Industry-Updates-A-2025-Perspective | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Insights/Demo-Widgets | bf77d80f-23dc-4bb8-b154-7bd141d3b807 | BDO.MicrositePage |
| /Insights/Demo-Widgets | fd92ce94-3cd6-4c9f-a2e5-d78a0b5c5e17 | BDO.Insight |
| /Insights/Demo-Widgets | 62ab34a6-3b70-4af1-8018-19cfdaa24d8f | BDO.Insight |
| /Insights/Demo-Widgets | 3cfa3b7a-fcca-434c-885b-c6299c9ffae7 | BDO.Insight |
| /Insights/Demo-Widgets | e05f067a-3ab2-4cf7-99a9-c3afc0566eea | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 45e4da4a-c914-40fe-999b-f9bbf017af9d | BDO.Deal |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | e68acba8-42b1-4c53-9dba-abcb81a2b8d5 | BDO.Deal |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 894b7458-e0d7-44d0-9675-737da8bbd311 | BDO.SpecialtiesArea |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 028fdecb-1d7f-46f1-95a6-8f54aaa609b8 | BDO.TestimonialType |
| /Insights/!Insight-category/Edit-me | 4a5272d0-74ac-439e-861d-e3b4ba24dcd4 | BDO.Insight |
| /Insights/!Insight-category/Edit-me | 304f6125-4687-4aa8-97dc-fdbe9e3720a7 | — |
| /Insights/!Insight-category/Edit-me | 2b7378e8-f871-48d0-9a1e-e5484f11f204 | — |
| /Insights/!Insight-category/Edit-me | bf8a4a0f-d44b-4c19-b523-0c2a2f929e9e | — |
| /Insights/Lukas-T | 731a2043-e3e2-49de-84c4-c93d371ae4aa | BDO.BusinessLine |
| /Insights/Lukas-T | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /Insights/Lukas-T | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /Insights/Lukas-T | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /Insights/Lukas-T | e4eec01b-c438-4949-a22d-6da8df8377ed | — |
| /Insights/DEV-Site-for-BCR | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR | 397167ae-7770-4c66-b45c-41d2aa13e1b2 | — |
| /Insights/DEV-Site-for-BCR | d2eb5bdf-1fd4-4ba8-bd15-b586134aca20 | — |
| /Insights/DEV-Site-for-BCR-2 | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR-2 | 397167ae-7770-4c66-b45c-41d2aa13e1b2 | — |
| /Insights/DEV-Site-for-BCR-2 | d2eb5bdf-1fd4-4ba8-bd15-b586134aca20 | — |
| /Insights/DEV-Site-for-BCR-2-(1) | 1cbacfd0-21ed-4bd7-b122-e58f3a84e6b7 | BDO.Insight |
| /Insights/DEV-Site-for-BCR-2-(1) | 1561c732-411c-4b85-8b7d-cb04c2b1d365 | BDO.Insight |
| /Insights/DEV-Site-for-BCR-2-(1) | e6619801-d131-4884-8621-7057df2b8d33 | BDO.Insight |
| /Insights/DEV-Site-for-BCR-2-(1) | 870461e3-dc0d-40b3-b6dc-5547c083a082 | BDO.Insight |
| /Insights/DEV-Site-for-BCR-2-(1) | 2af973a0-53ac-4580-8450-8f298c3e9d8e | BDO.Insight |
| /Insights/DEV-Site-for-BCR-2-(1) | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Insights/DEV-Site-for-BCR-2-(1) | 971ea600-8766-4645-a202-389d9d172afb | BDO.BlogPost |
| /Insights/DEV-Site-for-BCR-2-(1) | 35cc081a-a0b3-4e76-ab2f-a1d7abd5ed66 | BDO.BlogPost |
| /Insights/DEV-Site-for-BCR-2-(2) | 5dfa717e-09f6-479e-bd4b-15c739f5b97b | — |
| /Insights/DEV-Site-for-BCR-2-(2) | 397167ae-7770-4c66-b45c-41d2aa13e1b2 | — |
| /Insights/DEV-Site-for-BCR-2-(2) | d2eb5bdf-1fd4-4ba8-bd15-b586134aca20 | — |
| /Insights/DEV-Site-for-BCR-2-(3) | 673b0177-8e1c-4de7-992a-ddffc8ea7e95 | BDO.BusinessLine |
| /Insights/DEV-Site-for-BCR-2-(3) | 6c93edce-3fe4-4315-8384-19e5429b90df | BDO.BusinessLine |
| /Insights/EV-API-Test-1 | 00872476-11b4-4c43-aac1-e091f8c8e886 | BDO.Insight |
| /Insights/EV-API-Test-1 | 9d543512-0897-4df6-8daf-ecae71210e4e | BDO.Insight |
| /Insights/EV-API-Test-1 | 6f282c78-491a-49f0-8ac0-a6af32155423 | BDO.Insight |
| /Insights/EV-API-Test-1 | d434e693-6564-4427-8238-36e59bc7d86b | BDO.Insight |
| /Insights/EV-API-Test-1 | 720a7e25-c61d-4475-9137-897f82b97c3d | BDO.Insight |
| /Insights/EV-API-Test-1 | ee0e92ed-d0b0-49da-b35b-5a914bed3bc4 | BDO.Insight |
| /Insights/EV-API-Test-1 | 3dd47f86-0ac8-40bf-97c3-2ec548b1a0e0 | BDO.Insight |
| /Insights/EV-API-Test-1 | 3230db53-e3aa-436d-95da-402eb4a5944b | BDO.EventRegistrationForm |
| /Insights/EV-API-Test-1 | af1a8486-a2c4-49dc-b8d6-205b367526b7 | BDO.EventRegistrationForm |
| /Insights/EV-API-Test-1 | 71fb958a-34ca-4b20-a0b7-b4bdd26f22ae | BDO.Event |
| /Insights/EV-API-Test-1 | 65fa258c-9e4c-4c41-8c54-28ea40ea0368 | BDO.Event |
| /Insights/EV-API-Test-1 | 2baf5237-d372-47a9-9b4b-f94cb75affe7 | BDO.Event |
| /Insights/Test-creation-of-new-Insight-(2) | 8846c15e-5c04-4b01-8401-11058fddeea7 | BDO.Event |
| /Insights/Test-creation-of-new-Insight-(2) | 5b366574-5c84-4d06-935c-a4c433adcb69 | BDO.Event |
| /Insights/Test-creation-of-new-Insight-(2) | 468b3fae-ef57-411d-887b-378fc2700915 | BDO.Event |
| /Insights/Test-creation-of-new-Insight-(2) | 72252843-2552-4495-b3cc-b88a2c760249 | BDO.EventRegistrationForm |
| /Insights/Test-creation-of-new-Insight-(2) | 6fadd11c-bd73-483c-9cbe-78ee6dcc2bd5 | BDO.EventRegistrationForm |
| /Insights/Test-creation-of-new-Insight-(2) | a8fac9ca-3faa-4703-bf83-d1550f402890 | BDO.EventRegistrationForm |
| /Insights/Test-Ali | 0cb0ceb8-7c94-4c56-a83c-f60b2ab4fa35 | — |
| /Insights/EV-GWT-article-4 | 5baa9714-44de-4c3c-b854-ef2d99912023 | BDO.Event |
| /Insights/EV-GWT-article-4 | 9416914d-fa23-4f86-8a6b-1ba353fea15f | BDO.EventRegistrationForm |
| /Insights/EV-GWT-article-4 | ad31615f-d78d-40d3-93fb-edd963c4ff88 | BDO.Webinar |
| /Insights/EV-GWT-article-4 | 2525a6f1-a806-4d59-848c-dec756735500 | BDO.Webinar |
| /Insights/EV-GWT-article-4 | e6619801-d131-4884-8621-7057df2b8d33 | BDO.Insight |
| /Insights/EV-GWT-article-4 | 1cbacfd0-21ed-4bd7-b122-e58f3a84e6b7 | BDO.Insight |
| /Insights/EV-GWT-article-4 | 780b9e8b-b33f-486b-af21-81994d941788 | BDO.Insight |
| /Insights/EV-GWT-article-4 | 2af973a0-53ac-4580-8450-8f298c3e9d8e | BDO.Insight |
| /Insights/EV-GWT-Article-8 | 1386726d-2d98-4353-9082-dd9b3973b95b | BDO.Insight |
| /Insights/EV-GWT-article-9 | eaeeb2e2-e63d-470c-a2c6-feb3a64baf9c | BDO.Insight |

##### Widget References

**`BDO.Widget.InFocus`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In | cd7c7790-7723-446b-912b-aacc5dd6fb9e | BDO.InFocusPage |
| /Insights/Update-zu-geplanten-Anderungen-bei-der-Covid-19-In | 8b03ab85-afda-43e3-930d-0deb3e4792a9 | BDO.InFocusPage |
| /Insights/Key-takeaways-demo | 8b03ab85-afda-43e3-930d-0deb3e4792a9 | BDO.InFocusPage |
| /Insights/Key-takeaways-demo | cd7c7790-7723-446b-912b-aacc5dd6fb9e | BDO.InFocusPage |
| /Insights/Lape-Insight | 9e0ffad7-3dc3-4670-91b6-8ff03853d8b9 | BDO.InFocusPage |
| /Insights/Lape-Insight | cf209186-e1dc-4a66-a510-34d62b5c4b64 | BDO.InFocusPage |
| /Insights/Lape-Insight | 5fbbdc5c-f253-4d1a-8f04-b9ffaaac4cd8 | BDO.InFocusPage |
| /Insights/EV-GWT-Article-10 | 9e0ffad7-3dc3-4670-91b6-8ff03853d8b9 | BDO.InFocusPage |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/RK-Category/Insight-Page-test-to-KR | 2563ed68-00e3-4e8e-94b3-17b658c363d0 | _(media file)_ |
| /Insights/E2E_Insight_Category_Automated/JV-Insight | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |
| /Insights/EV-GWT-Article-10 | 62ae97f9-5a14-4e7d-a155-72a8e3d7c6a0 | _(media file)_ |
| /Insights/Matas-Quote-demo-(1) | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (22 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Demo-Insight-without-sidebar-(1) | ceecd594-c1da-421d-8633-39acd1ff1d09 | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 7ec96890-fff8-46b4-8f6d-9aa875cc2958 | BDO.Insight |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 3801b05c-8bdf-4ac3-851d-2cd07ffde799 | BDO.Insight |
| /Insights/Test-creation-of-new-Insight-(2) | 2af973a0-53ac-4580-8450-8f298c3e9d8e | BDO.Insight |
| /Insights/Test-creation-of-new-Insight-(2) | 83a19c0e-e4b6-492a-99db-fe880ae579c8 | BDO.Insight |
| /Insights/Test-creation-of-new-Insight-(2) | 00872476-11b4-4c43-aac1-e091f8c8e886 | BDO.Insight |
| /Insights/Test-creation-of-new-Insight-(2) | 9d543512-0897-4df6-8daf-ecae71210e4e | BDO.Insight |
| /Insights/Test-creation-of-new-Insight-(2) | 6f282c78-491a-49f0-8ac0-a6af32155423 | BDO.Insight |
| /Insights/Matas-Quote-demo | a5615ace-7620-499c-847a-7ab12e5bd4a4 | BDO.Insight |
| /Insights/Matas-Quote-demo | b2b51635-1301-4bd2-a09f-98c90d5abce3 | BDO.Insight |
| /Insights/Matas-Quote-demo | 766feb11-f0ec-4367-95c1-f25ce29dfb88 | BDO.Insight |
| /Insights/Matas-Quote-demo | f8df97f7-8578-425a-9872-53b58c0b2eab | BDO.Insight |
| /Insights/Matas-Quote-demo | 1386726d-2d98-4353-9082-dd9b3973b95b | BDO.Insight |
| /Insights/Matas-Quote-demo | eaeeb2e2-e63d-470c-a2c6-feb3a64baf9c | BDO.Insight |
| /Insights/test-one-two | 1561c732-411c-4b85-8b7d-cb04c2b1d365 | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | a5615ace-7620-499c-847a-7ab12e5bd4a4 | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | b2b51635-1301-4bd2-a09f-98c90d5abce3 | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | 766feb11-f0ec-4367-95c1-f25ce29dfb88 | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | f8df97f7-8578-425a-9872-53b58c0b2eab | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | 1386726d-2d98-4353-9082-dd9b3973b95b | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | eaeeb2e2-e63d-470c-a2c6-feb3a64baf9c | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | 3938c0b3-5bb5-48f0-bd82-a17bdfc664e5 | BDO.Insight |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `contributors` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Industry-Updates-A-2025-Perspective | 7f205a12-ee2e-4ea6-a1a8-d8ab578a591e | BDO.ExternalPerson |
| /Insights/Industry-Updates-A-2025-Perspective | 2707e2e8-0cd1-4936-baa0-a0762de69404 | BDO.ExternalPerson |
| /Insights/Industry-Updates-A-2025-Perspective | e5bcc1ad-33c1-4dbe-be70-fdc933cc3f43 | BDO.ExternalPerson |
| /Insights/Industry-Updates-A-2025-Perspective | 4f64b483-b3cd-434c-91c9-068bb3cddcb9 | BDO.InternalPerson |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (58 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Industry-Updates-A-2025-Perspective | 9121c602-2e5f-4855-b7e1-ddf8d81080c2 | BDO.Person |
| /Insights/Industry-Updates-A-2025-Perspective | a8e3e098-17fd-492f-bcc1-cfadc97103ca | BDO.Person |
| /Insights/Industry-Updates-A-2025-Perspective | 3cd13b92-7b34-4523-82f0-6677b8601256 | BDO.Person |
| /Insights/Insight-with-hero | 38349a1e-a9bf-4575-a0a5-e7cc2c74f04b | BDO.Person |
| /Insights/Insight-with-hero | 9121c602-2e5f-4855-b7e1-ddf8d81080c2 | BDO.Person |
| /Insights/Insight-with-hero | 8b149177-9732-4021-95d0-76420cb9a5d4 | BDO.Person |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Insights/JJ-Insight-category/JJ-Insight-group/Testing-tagging | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | c2ca32bb-1ab2-401e-ba56-d5b7526b3293 | BDO.Person |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | 79120de9-6cbb-4c25-89f0-e0ffd85242d9 | BDO.Person |
| /Insights/JJ-Insight-category/No-sidebar-Insight-(1) | 31d93727-03fe-454b-be19-e301777510d8 | BDO.Person |
| /Insights/JJ-Insight-category/JJ-Article | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |
| /Insights/Insight-w-o-tagging | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Insights/Insight-w-o-tagging | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Insights/Insight-w-o-tagging | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Insights/Insight-w-o-tagging | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Insights/Insight-1 | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /Insights/Insight-1 | ebbdb5cd-bf88-4187-9abb-f7f1c9ccad5f | BDO.Person |
| /Insights/Insight-1 | 4bc99152-ead1-45b5-b07b-bd5fbffc8541 | BDO.Person |
| /Insights/Insight-1 | e83ab225-caaf-426f-8707-01a88c166690 | BDO.Person |
| /Insights/Insight-1 | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |
| /Insights/Insight-1 | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |
| /Insights/Insight-1 | c5f0ad09-48c0-4b5b-a50c-ead79ebd9b36 | BDO.Person |
| /Insights/Insight-1 | 1bf12bd1-526f-4b69-9d03-e11c9b194df8 | BDO.Person |
| /Insights/Insight-1 | f1f14a0d-1987-41e3-b16c-0d74d4a1bd24 | BDO.Person |
| /Insights/Insight-1 | e8207da0-3542-4f01-96c4-a58f18e3bc76 | BDO.Person |
| /Insights/Insight-1 | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Insights/Insight-1 | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Insights/RK-Category/Insight-Page-test-to-KR | f38324e7-ff87-4265-bb0f-b4fc70a2243b | — |
| /Insights/RK-Category/Insight-Page-test-to-KR | e8207da0-3542-4f01-96c4-a58f18e3bc76 | BDO.Person |
| /Insights/RK-Category/Insight-Page-test-to-KR | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Insights/!Insight-category/Edit-me | f1f14a0d-1987-41e3-b16c-0d74d4a1bd24 | BDO.Person |
| /Insights/!Insight-category/Edit-me | e83ab225-caaf-426f-8707-01a88c166690 | BDO.Person |
| /Insights/Hikaruuuu | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /Insights/Hikaruuuu | 4bc99152-ead1-45b5-b07b-bd5fbffc8541 | BDO.Person |
| /Insights/Hikaruuuu | f1f14a0d-1987-41e3-b16c-0d74d4a1bd24 | BDO.Person |
| /Insights/DEV-Site-for-BCR | e0113ddc-18e5-4fcd-920f-61f91b40c8b5 | — |
| /Insights/DEV-Site-for-BCR | 714dae0b-c94b-4a65-b439-770f73658de3 | — |
| /Insights/DEV-Site-for-BCR-2 | e0113ddc-18e5-4fcd-920f-61f91b40c8b5 | — |
| /Insights/DEV-Site-for-BCR-2 | 714dae0b-c94b-4a65-b439-770f73658de3 | — |
| /Insights/DEV-Site-for-BCR-2-(1) | e0113ddc-18e5-4fcd-920f-61f91b40c8b5 | — |
| /Insights/DEV-Site-for-BCR-2-(1) | 714dae0b-c94b-4a65-b439-770f73658de3 | — |
| /Insights/DEV-Site-for-BCR-2-(2) | e0113ddc-18e5-4fcd-920f-61f91b40c8b5 | — |
| /Insights/DEV-Site-for-BCR-2-(2) | 714dae0b-c94b-4a65-b439-770f73658de3 | — |
| /Insights/Testing-new-1 | e3df18ab-8ac8-4e0f-895e-7b5388f6eb61 | BDO.Person |
| /Insights/Testing-new-1 | 3cd13b92-7b34-4523-82f0-6677b8601256 | BDO.Person |
| /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(1) | e3df18ab-8ac8-4e0f-895e-7b5388f6eb61 | BDO.Person |
| /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(1) | 3cd13b92-7b34-4523-82f0-6677b8601256 | BDO.Person |
| /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(2) | e3df18ab-8ac8-4e0f-895e-7b5388f6eb61 | BDO.Person |
| /Insights/How-New-EU-Tax-And-Transfer-Pricing-Rules-May-(2) | 3cd13b92-7b34-4523-82f0-6677b8601256 | BDO.Person |
| /Insights/DEV-Site-for-BCR-2-(3) | e0113ddc-18e5-4fcd-920f-61f91b40c8b5 | — |
| /Insights/DEV-Site-for-BCR-2-(3) | 714dae0b-c94b-4a65-b439-770f73658de3 | — |
| /Insights/Insight-Page-Title-H1 | c2ca32bb-1ab2-401e-ba56-d5b7526b3293 | BDO.Person |
| /Insights/Insight-Page-Title-H1 | 79120de9-6cbb-4c25-89f0-e0ffd85242d9 | BDO.Person |
| /Insights/Insight-Page-Title-H1 | 31d93727-03fe-454b-be19-e301777510d8 | BDO.Person |
| /Insights/EV-GWT-Article-10 | 278a3d65-cf6e-43c6-b1f6-eab8f23234a3 | BDO.Person |
| /Insights/EV-GWT-Article-10 | 79120de9-6cbb-4c25-89f0-e0ffd85242d9 | BDO.Person |
| /Insights/EV-GWT-Article-10 | f36fdb67-117f-4d91-b797-cca628ebfb39 | BDO.Person |

##### Widget References

**`BDO.Widget.NewsCarousel`** — property `featuredNews` — PageSelector (7 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Testing-new-1 | ca635b36-3a82-4a16-bb1d-bf4590cedabb | BDO.SectionNews |
| /Insights/Testing-new-1 | e087cc58-3235-4307-9608-e7b62e1f54df | BDO.NewsGroup |
| /Insights/Testing-new-1 | 2da6a50b-d3f2-4b05-90f5-ddd76506326c | BDO.NewsGroup |
| /Insights/Testing-new-1 | 4b918724-33e2-4716-ae3d-bedad26ac46a | BDO.NewsGroup |
| /Insights/Testing-new-1 | 98edeef9-3f28-4e75-9986-fb0ccd210ba8 | BDO.NewsGroup |
| /Insights/Insighast-(1)2 | e89af266-df6a-44c0-9dbd-cca8f990fa29 | BDO.NewsArticle |
| /Insights/Insighast-(1)2 | 40c55aca-dfe4-45a2-8430-24b9318436ad | BDO.NewsArticle |

##### Widget References

**`BDO.Widget.RelatedContentCarousel`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/JJ-New-Insight-no-modifications | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |
| /Insights/Matas-Quote-demo-(1) | dcbacc5a-0ed9-423a-9dd6-4fea750a9a63 | _(media file)_ |

##### Widget References

**`BDO.Widget.RelatedContentCarousel`** — property `featuredPages` — PageSelector (9 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | 45e4da4a-c914-40fe-999b-f9bbf017af9d | BDO.Deal |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | 7f0c3897-b2d2-4d15-9d8d-9ac001e4a991 | BDO.Event |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | ebf7244c-b13a-40e1-a0e3-1ce02f9910fa | BDO.Event |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | 0902cc03-d91a-45cc-b3be-db6566f7f89f | BDO.Event |
| /Insights/EV-API-Test-1-KR-6-9-TESTing-insights-2 | 5b7333b6-fdfa-4784-9b56-52634f80381b | BDO.Event |
| /Insights/JJ-New-Insight-no-modifications | a5615ace-7620-499c-847a-7ab12e5bd4a4 | BDO.Insight |
| /Insights/Matas-Quote-demo-(1) | 2d774683-014b-4041-9579-7b83695a1f37 | BDO.InFocusPage |
| /Insights/Matas-Quote-demo-(1) | 1386726d-2d98-4353-9082-dd9b3973b95b | BDO.Insight |

#### BDO.InsightCategory

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Test | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

#### BDO.InsightGroup

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights/Lukas-testing-(2)/Lukas-Testing | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

#### BDO.LocationCity

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations/API | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations/Location-city-(3) | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations/Location-city-(3) | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Locations/Location-city-(3) | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Locations/Location-city-(3) | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations/Location-city-(3) | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Locations/Location-city-(3) | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Locations/Location-city-(3) | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Locations/Location-city-(3) | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Locations/Location-city-(3) | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Locations/Location-city-(3) | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Locations/Location-city-(3) | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Locations/Location-city-(3) | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

#### BDO.LocationOffice

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations/Location-City/Regent-Street | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Page Type Field References

**property `OfficeImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations/Location-1/Office-1 | 24ab8144-4957-402f-91a4-38f0c25f497d | _(media file)_ |

#### BDO.Locations

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Locations | 894b7458-e0d7-44d0-9675-737da8bbd311 | BDO.SpecialtiesArea |
| /Locations | e89af266-df6a-44c0-9dbd-cca8f990fa29 | BDO.NewsArticle |
| /Locations | 39f78e4d-98d0-4a4d-96c5-3e4c372d3ac2 | BDO.Insight |
| /Locations | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |

#### BDO.MicrositeMasterPage

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/OG-Master-page | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Lape-Microsite | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Lape-Microsite | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Microsites/Lape-Microsite | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Microsites/Lape-Microsite | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (13 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/NV | 62057193-0930-4591-9117-a7cf1c7fb5af | BDO.MicrositePage |
| /Microsites/NV | 2b495eed-170a-4ee3-bf34-d3c0de775631 | BDO.MicrositePage |
| /Microsites/NV | da777dc9-58e0-4be3-91fc-455b80c5f07d | BDO.MicrositePage |
| /Microsites/Lape-Microsite | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Microsites/Lape-Microsite | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Microsites/Lape-Microsite | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Microsites/Lape-Microsite | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Microsites/Lape-Microsite | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Microsites/Lape-Microsite | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Microsites/Lape-Microsite | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Microsites/Lape-Microsite | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /Microsites/MV-Microsite | 3938c0b3-5bb5-48f0-bd82-a17bdfc664e5 | BDO.Insight |
| /Microsites/MV-Microsite | 1561c732-411c-4b85-8b7d-cb04c2b1d365 | BDO.Insight |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/New-Master-page | 482706ac-88db-4ff0-9005-a064129968fb | BDO.MicrositePage |
| /Microsites/New-Master-page | e9d3e97c-6283-4729-93ca-c5cf07cdea47 | BDO.MicrositePage |
| /Microsites/New-Master-page | 4a3f91fc-6fe3-4c57-beed-3ac568dd2803 | BDO.MicrositePage |
| /Microsites/New-Master-page | 784869f1-f470-425d-87b4-205f4c9c24b9 | BDO.MicrositePage |
| /Microsites/New-Master-page | 482706ac-88db-4ff0-9005-a064129968fb | BDO.MicrositePage |
| /Microsites/New-Master-page | e9d3e97c-6283-4729-93ca-c5cf07cdea47 | BDO.MicrositePage |
| /Microsites/New-Master-page | 4a3f91fc-6fe3-4c57-beed-3ac568dd2803 | BDO.MicrositePage |
| /Microsites/New-Master-page | 784869f1-f470-425d-87b4-205f4c9c24b9 | BDO.MicrositePage |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/NV | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /Microsites/NV | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |
| /Microsites/MV-Microsite | 8209a225-1236-44e0-84ff-da7783e8b4e7 | BDO.MicrositeMasterPage |
| /Microsites/MV-Microsite | 41f80a30-153d-4ce7-9af4-b0782ab9bfc9 | BDO.MicrositeMasterPage |
| /Microsites/MV-Microsite | dea19c24-7a9a-4c58-aa47-819e262884ef | — |
| /Microsites/MV-Microsite | 4bd7f822-b92a-4a4d-b5f8-3259b954b60e | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/MV-Microsite | 1aaf55ba-e9c0-4f6b-aeb6-9fdc3c3db73b | BDO.Industry |

#### BDO.MicrositePage

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites-staging/Microsite-Master-Page/Microsite-page/a | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Page Type Field References

**property `MicrositeImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/E2E-Microsite/694818_E2E_Microsite-Test | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Microsites/Lape-Microsite/Lape-Microsite-Page | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Test-Social-media-icons/Social-media-icons | d387c275-34d7-4b2f-b53f-1204d6032e47 | _(media file)_ |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `featuredEventsAndWebinars` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Test-Social-media-icons/Social-media-icons | d452bc7f-e57b-4000-9e12-910e074f5281 | BDO.Webinar |
| /Microsites/Test-Social-media-icons/Social-media-icons | 9de930a6-ab16-471a-af4c-73c7a41a3c80 | BDO.Event |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Test-Social-media-icons/Social-media-icons | da777dc9-58e0-4be3-91fc-455b80c5f07d | BDO.MicrositePage |
| /Microsites/Test-Social-media-icons/Social-media-icons | e3cc5c60-ce2e-41cc-91dc-c8e10c02f454 | BDO.Insight |
| /Microsites/Test-Social-media-icons/Social-media-icons | 1b795c9e-481e-45c4-9fe4-9843fccee3b5 | BDO.Insight |
| /Microsites/694818_E2E_Microsite/694818_E2E_Microsite-Page | 5b7333b6-fdfa-4784-9b56-52634f80381b | BDO.Event |
| /Microsites/694818_E2E_Microsite/694818_E2E_Microsite-Page | 0902cc03-d91a-45cc-b3be-db6566f7f89f | BDO.Event |
| /Microsites/694818_E2E_Microsite/694818_E2E_Microsite-Page | 7f0c3897-b2d2-4d15-9d8d-9ac001e4a991 | BDO.Event |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | c8a829c9-cf30-4c21-9138-7633514d3fa0 | _(media file)_ |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (5 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Test-Social-media-icons/Social-media-icons | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /Microsites/694818_E2E_Microsite/694818_E2E_Microsite-Page | eb2f5805-6307-41e7-b9fe-dd31f1592383 | BDO.Person |
| /Microsites-staging/Microsite-Master-Page/Microsite-page | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /Microsites-staging/Microsite-Master-Page/Microsite-page | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /Microsites-staging/Microsite-Master-Page/Microsite-page/Mirosite-Test/Microsite-3rd-list-item | e83ab225-caaf-426f-8707-01a88c166690 | BDO.Person |

##### Widget References

**`BDO.Widget.NewsCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Test-Social-media-icons/Social-media-icons | 36739f40-8b2c-4356-949c-f9668f5946e4 | _(media file)_ |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /Microsites/RK-Master-Microsite/RK-Microsite-page | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Microsites/Test-Social-media-icons/Social-media-icons | aade0cf7-1951-45ef-ba70-6bd0858b513b | BDO.InsightCategory |

#### BDO.NewsArticle

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /News/IT/Hvorfor-bruker-vi-det | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /News/2024/Lape-News-Article | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /News/2024/Lape-News-Article | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /News/2024/Lape-News-Article | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /News/2024/Lape-News-Article | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /News/2024/Lape-News-Article | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /News/2024/Lape-News-Article | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /News/2024/Lape-News-Article | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /News/2024/Lape-News-Article | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /News/2024/Lape-News-Article | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /News/2024/Lape-News-Article | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /News/2024/Lape-News-Article | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /News/2024/Lape-News-Article | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (24 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /News/Group-3/News-article | 4bc99152-ead1-45b5-b07b-bd5fbffc8541 | BDO.Person |
| /News/Group-3/News-article | 899226ea-6cb6-4064-9a02-db026fe7705b | BDO.Person |
| /News/Group-3/News-article | 1bf12bd1-526f-4b69-9d03-e11c9b194df8 | BDO.Person |
| /News/Group-3/News-article | a1cb2794-a63c-4ff2-8493-7e24b1754861 | BDO.Person |
| /News/Group-3/News-article | e83ab225-caaf-426f-8707-01a88c166690 | BDO.Person |
| /News/Group-3/News-article | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /News/Group-3/News-article | 1146c973-15d0-4dd9-854c-6db4f445d880 | BDO.Person |
| /News/Group-3/News-article | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /News/Group-3/News-article | e8207da0-3542-4f01-96c4-a58f18e3bc76 | BDO.Person |
| /News/Group-3/News-article | c5f0ad09-48c0-4b5b-a50c-ead79ebd9b36 | BDO.Person |
| /News/Group-3/News-article | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |
| /News/Group-3/News-article | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |
| /News/Group-3/News-article | 89b102d3-f477-47c1-94ef-791a0e3fe0c3 | BDO.Person |
| /News/Group-3/News-article | ebbdb5cd-bf88-4187-9abb-f7f1c9ccad5f | BDO.Person |
| /News/Group-3/News-article | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |
| /News/Group-3/News-article | ff60f7cf-6863-4765-815a-de7342dd457a | BDO.Person |
| /News/Group-3/News-article | 6c6ed4d1-51f1-4202-8796-7ec8104e4d89 | BDO.Person |
| /News/Group-3/News-article | c331e87f-818b-4975-a988-546db08a1ce0 | BDO.Person |
| /News/Group-3/News-article | 4becb805-9931-487f-acff-e0cb9bbce06f | BDO.Person |
| /News/Group-3/News-article | f1f14a0d-1987-41e3-b16c-0d74d4a1bd24 | BDO.Person |
| /News/Group-3/News-article | f38324e7-ff87-4265-bb0f-b4fc70a2243b | — |
| /News/Group-3/News-article | e8207da0-3542-4f01-96c4-a58f18e3bc76 | BDO.Person |
| /News/Group-3/News-article | b042768a-178f-48f5-b34b-79bf27b85370 | BDO.Person |
| /News/Group-3/News-article | 3f57f21e-103d-4c98-bb65-0135627a7f4f | BDO.Person |

#### BDO.Person

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (12 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /People/Tadas-Lape | 7769f344-5199-4ff4-b4c4-7ce628015b7f | _(media file)_ |
| /People/Matas-Vaitkus | 70a16726-abd3-482b-99a5-0996e3dce956 | _(media file)_ |
| /Our-People/Mr | 83076c43-c32c-4d1c-a051-8c44a759c24c | _(media file)_ |
| /Our-people/Person-Media | cbb01e47-f348-4e9a-b8bb-d6e11899e2cf | _(media file)_ |
| /Our-people/Person-Attach | 8fcea501-9744-4e9a-b4d4-685d678d9501 | _(media file)_ |
| /Our-people/Person-Another-Site | 83076c43-c32c-4d1c-a051-8c44a759c24c | _(media file)_ |
| /Our-People/Freya-Bates | 890ec1d7-5d2a-4375-8141-6d18a8692924 | _(media file)_ |
| /Our-People/Lisa-Hayes | 75f0f0cd-83bb-4447-a8d8-8c2dbc8edc59 | _(media file)_ |
| /Our-People/Person-Personovich | 29e64bca-763e-4fd8-a365-f40965063bda | _(media file)_ |
| /Our-People/Matas-Vaitkus | 83076c43-c32c-4d1c-a051-8c44a759c24c | _(media file)_ |
| /Our-People/Person-JJ | 32dd56d2-5e8b-44cb-8eba-2dc663d70660 | _(media file)_ |
| /Our-People/New-API-Test | ac6dbfdb-3638-4b1f-a808-2ee4b3e41211 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Our-People/Rita-Hodkiewicz | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Our-People/Rita-Hodkiewicz | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Our-People/Rita-Hodkiewicz | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Our-People/Rita-Hodkiewicz | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (11 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Our-People/Rita-Hodkiewicz | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Our-People/Rita-Hodkiewicz | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Our-People/Rita-Hodkiewicz | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Our-People/Rita-Hodkiewicz | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Our-People/Rita-Hodkiewicz | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Our-People/Rita-Hodkiewicz | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Our-People/Rita-Hodkiewicz | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Our-People/Rita-Hodkiewicz | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /Our-People/Person-JJ | 1561c732-411c-4b85-8b7d-cb04c2b1d365 | BDO.Insight |
| /Our-People/Person-JJ | 780b9e8b-b33f-486b-af21-81994d941788 | BDO.Insight |
| /Our-People/Person-JJ | 1cbacfd0-21ed-4bd7-b122-e58f3a84e6b7 | BDO.Insight |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `featuredPages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Our-People/CAB-Daniel-Danson-(3) | f3fc6785-7833-42ec-bc0c-183f2020eb0b | BDO.Insight |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Our-People/CAB-Daniel-Danson-(3) | f3fc6785-7833-42ec-bc0c-183f2020eb0b | BDO.Insight |
| /Our-People/CAB-Daniel-Danson-(3) | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /Our-People/CAB-Daniel-Danson-(3) | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /Our-People/CAB-Daniel-Danson-(3) | 772c0163-13e5-41a7-ade3-0413c0f149cf | BDO.IndustryCategory |
| /Our-People/CAB-Daniel-Danson-(3) | e3de0027-ca72-48fb-a7a1-e7d0d4f4853c | BDO.LegalPage |
| /Our-People/CAB-Daniel-Danson-(3) | a725c10b-2c77-43fa-b3e3-d333726d1ad1 | — |
| /Our-People/CAB-Daniel-Danson-(3) | 09cbb354-2b4b-4590-b700-9e672f4c5b96 | — |
| /Our-People/CAB-Daniel-Danson-(3) | 9c4dc2d1-d8d7-44e4-9cc4-6c3884b3dfda | BDO.Deal |

#### BDO.RemoteDeal

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Deals/Deal-From-DEV-For-demo | 890ec1d7-5d2a-4375-8141-6d18a8692924 | _(media file)_ |
| /Deals/Acquisition-Deal | a1796b34-5c81-4766-8c6a-13c4c8cfd1af | _(media file)_ |
| /Deals/Advice-Allegion-in-the-acquisition-of-Dorcas | 75f0f0cd-83bb-4447-a8d8-8c2dbc8edc59 | _(media file)_ |

#### BDO.SectionAbout

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us | 2563ed68-00e3-4e8e-94b3-17b658c363d0 | _(media file)_ |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `featuredEventsAndWebinars` — PageSelector (7 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us | d452bc7f-e57b-4000-9e12-910e074f5281 | BDO.Webinar |
| /About-Us | 371dfa0b-3366-4d32-8d53-33f1621e3f03 | BDO.Webinar |
| /About-Us | 89534182-b6f5-4d9f-8797-b0ec1319c012 | BDO.Event |
| /About-Us | 4c09ad92-7a5e-44d8-af13-0cb7ea8152d2 | BDO.Webinar |
| /About-Us | 3d9cb85f-f188-48fb-9390-07d42a61c13c | BDO.Event |
| /About-Us | e825a689-a4ed-4c57-b555-1fb2c5724f56 | BDO.Webinar |
| /About-Us | 33c6d4b9-4719-41c6-a77f-5b8147f24510 | BDO.Webinar |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us | 4d0eb532-a0d7-488a-9e6b-78b1d5e35165 | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us | c8b2d233-8cef-4916-8fe6-d9d4a14d86b9 | BDO.Insight |
| /About-Us | 85a652fd-4203-4ace-bbaa-e83f5f01690e | BDO.Insight |
| /About-Us | 99d3f308-ff30-462a-9430-db94965df527 | BDO.Insight |
| /About-Us | b8ae4a77-e551-47b3-bb25-df9ece94af46 | BDO.Insight |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us | 06d2379c-1b29-4a85-83a1-3e6c30f69fce | _(media file)_ |
| /About-Us | 2563ed68-00e3-4e8e-94b3-17b658c363d0 | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (12 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /About-Us | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /About-Us | 731a2043-e3e2-49de-84c4-c93d371ae4aa | BDO.BusinessLine |
| /About-Us | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /About-Us | 1598c894-73f7-4919-9e39-109a9632e6f0 | BDO.BusinessLine |
| /About-Us | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |
| /About-Us | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /About-Us | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /About-Us | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /About-Us | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |
| /About-Us | 83c21acf-78bf-4662-9fc6-7b99a8951605 | BDO.IndustryCategory |
| /About-Us | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /About-Us | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |

#### BDO.SectionBusinessStrategies

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Business-Strategies | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Business-Strategies | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Business-Strategies | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Business-Strategies | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Business-Strategies | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Business-Strategies | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Business-Strategies | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Business-Strategies | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Business-Strategies | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

#### BDO.SectionCareers

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Section-Careers | 19fb392c-bed1-468b-9186-d2861f5d8a8e | _(media file)_ |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers | 8b149177-9732-4021-95d0-76420cb9a5d4 | BDO.Person |
| /Careers | 9121c602-2e5f-4855-b7e1-ddf8d81080c2 | BDO.Person |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Careers | a349e414-a135-4b20-85ae-0ff845e32e7e | BDO.IndustryService |

#### BDO.SectionEvents

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Events | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

#### BDO.SectionIndustries

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries | 4d0eb532-a0d7-488a-9e6b-78b1d5e35165 | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (5 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries | c0f1c6ff-9910-47ec-8ccb-4a25bbfa756a | BDO.IndustryCategory |
| /Industries | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /Industries | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /Industries | f48132c9-ed42-4242-bcfa-983c6bf810b5 | BDO.IndustryCategory |
| /Industries | a5b15861-22f0-467c-8460-7dbbac01c4be | BDO.IndustryCategory |

#### BDO.SectionInsightsPage

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Insights | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /Insights | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /Insights | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /Insights | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /Insights | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /Insights | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /Insights | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /Insights | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |

#### BDO.SectionPeoplePage

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /People | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |
| /Our-People | 19fb392c-bed1-468b-9186-d2861f5d8a8e | _(media file)_ |

#### BDO.SectionServices

##### Widget References

**`BDO.Widget.KeyContacts`** — property `contributors` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში | 3d298fc6-9658-4732-9d2d-c68466b5c897 | BDO.ExternalPerson |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში | eb2f5805-6307-41e7-b9fe-dd31f1592383 | BDO.Person |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში | dee1a10b-b697-4573-b3e9-9b59211261da | BDO.SectionBlogs |
| /საქართველოში | beb65c42-85fa-4de9-b948-e7429f9a247d | BDO.Blog |
| /საქართველოში | 35122513-f437-4e71-8e4b-d7d5e3a8f2d4 | BDO.Blog |
| /საქართველოში | 83d259b0-dd51-4d9c-9f60-9aa351da0954 | BDO.Blog |

#### BDO.SectionSpecialties

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Specialties | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Specialties | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Specialties | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Specialties | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Specialties | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Specialties | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Specialties | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Specialties | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Specialties | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties | ede5b8dc-66fe-4cc6-ac71-c94f7536217a | BDO.BusinessLine |

#### BDO.Service

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `featuredPages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | a8f0a97e-0bc3-4635-9298-27427b2e04b0 | BDO.SpecialtiesArea |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | 3a311769-e206-407a-adf2-daac23e676ff | — |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | cc643605-70f1-4005-924d-3396573339e6 | BDO.Blog |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | a7320941-ff35-451b-8991-13be51b8484b | BDO.Search |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | 7d4bd9c3-c5c9-413e-865d-1033fdfead83 | BDO.Person |

##### Widget References

**`BDO.Widget.RelatedContentCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/BDO-Digital/Financial-Services/Deal-Advisory | 6c438aea-8547-4799-bbe4-c285dc7846bd | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | 8413ab13-9726-47e2-b721-15d29fd91297 | BDO.BusinessLine |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | 1598c894-73f7-4919-9e39-109a9632e6f0 | BDO.BusinessLine |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | ebdd871f-86de-4523-8bf4-68dfd65649f0 | BDO.BusinessLine |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | 731a2043-e3e2-49de-84c4-c93d371ae4aa | BDO.BusinessLine |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (15 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | ef5fe694-b8ea-47bf-9fb9-34b74e2acef6 | BDO.Industry |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | 358bfd5b-434b-405b-bc63-53b59f3dd8c6 | BDO.Industry |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | 74ed8b0b-b95b-4c36-b382-f03cc087b767 | BDO.Industry |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | 511d2568-8d10-4826-830d-4178e4c08b0f | BDO.Industry |
| /საქართველოში/Advisory/Cybersecurity/Ethical-Hacking | 1335ccb6-b455-4f12-b638-cf39b6687203 | BDO.Industry |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio | 2d4ee3fb-f742-4a1b-8615-86802e1f0754 | BDO.BlogPost |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio | 50ead8ca-87ba-4027-9b74-48e90dcb568e | BDO.BlogPost |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio | 77fb25f5-7841-4e45-b15c-e430bd13509f | BDO.BlogPost |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio | a71e81b6-b7d2-40c5-909e-f1fb6bfdc56e | BDO.BlogPost |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | e9d3e97c-6283-4729-93ca-c5cf07cdea47 | BDO.MicrositePage |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | 784869f1-f470-425d-87b4-205f4c9c24b9 | BDO.MicrositePage |
| /საქართველოში/Audit-Assurance/Audit-Services/Audit-Quality | 4a3f91fc-6fe3-4c57-beed-3ac568dd2803 | BDO.MicrositePage |
| /საქართველოში/Demo-Business-line/Demo-Service-Area/Demo-Service | 14adf4a9-d352-4cdb-b71a-049561bbd840 | BDO.Industry |
| /საქართველოში/Demo-Business-line/Demo-Service-Area/Demo-Service | 4f5d04d2-f99c-4784-b59a-8c69a2588191 | BDO.IndustryService |
| /საქართველოში/Demo-Business-line/Demo-Service-Area/Demo-Service | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |

#### BDO.ServiceArea

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (4 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /საქართველოში/MV-Business-Line/MV-Service-area | 357d13de-9253-4c93-be4b-4186114f11b7 | BDO.Event |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (19 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | 40c55aca-dfe4-45a2-8430-24b9318436ad | BDO.NewsArticle |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | e89af266-df6a-44c0-9dbd-cca8f990fa29 | BDO.NewsArticle |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | 0b683d06-3896-4526-9b55-c6cd1f4b49c4 | BDO.Insight |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | 0db626f1-bc1a-4960-8249-c219de22e963 | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /საქართველოში/Consulting-Unternehmensberatung/יעוץ-עסקי3 | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | a2eeaec9-d621-4d2a-8f2f-0676d8da04d2 | BDO.Insight |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | 40c55aca-dfe4-45a2-8430-24b9318436ad | BDO.NewsArticle |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | 8c262182-530d-43ec-b803-a08bbc7747a1 | BDO.NewsArticle |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | e3694ec2-576e-41b5-85a0-d4060c70a659 | BDO.Service |
| /საქართველოში/MV-Business-Line/MV-Service-area | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /საქართველოში/MV-Business-Line/MV-Service-area | 2308ede4-4fbb-4061-b2b7-e152a3835026 | BDO.BlogPost |
| /საქართველოში/MV-Business-Line/MV-Service-area | 35cc081a-a0b3-4e76-ab2f-a1d7abd5ed66 | BDO.BlogPost |

##### Widget References

**`BDO.Widget.Faq`** — property `pages` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | 9f4cf1cf-96b0-4d15-9154-ce4360d8cd26 | BDO.FaqPage |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | bf4a579e-7301-47b4-9574-9ae782e34e6f | BDO.FaqPage |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | 89b4b5a7-eed5-4e36-85bf-f3b72672a547 | BDO.FaqPage |
| /საქართველოში/MV-Business-Line/MV-Service-area | 7673b547-fb6a-4f81-b0dd-56ad8863a97c | — |
| /საქართველოში/MV-Business-Line/MV-Service-area | 5c0484a4-8725-41d3-8fdd-a953d62c33aa | — |
| /საქართველოში/MV-Business-Line/MV-Service-area | 6e5f902b-adb6-4746-88bf-8089adc20869 | — |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory/Actuarial-Services | cea5dd54-afbe-4b9a-8c2a-ec35f7db1a23 | BDO.Insight |
| /Advisory/Advisory/BDO-Digital | b58aa369-5dbd-40de-b73e-909929e40111 | BDO.Insight |
| /Advisory/Advisory/BDO-Digital | b58aa369-5dbd-40de-b73e-909929e40111 | BDO.Insight |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (9 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory/Actuarial-Services | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory/Actuarial-Services | fa8f6343-64cb-41a6-8075-f86ef92edd61 | BDO.Insight |
| /Advisory/Advisory/Actuarial-Services | 314c0324-e0a7-4da1-8eaf-2f5539f26f13 | BDO.BusinessLine |
| /Advisory/Advisory/BDO-Digital | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Advisory/Advisory/BDO-Digital | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory/BDO-Digital | b0ae6e00-6105-4c0e-9b3d-2007a03fd8e1 | BDO.Event |
| /Advisory/Advisory/BDO-Digital | 1cae4db4-c691-4fc4-a4a6-9d9bb7f883a7 | BDO.Insight |
| /Advisory/Advisory/BDO-Digital | 268363c8-b936-4ca3-a311-5059a84b5960 | BDO.ServiceArea |
| /Advisory/Advisory/BDO-Digital | b0ae6e00-6105-4c0e-9b3d-2007a03fd8e1 | BDO.Event |

##### Widget References

**`BDO.Widget.InFocus`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/ESG-Suistanability-reporting | cf209186-e1dc-4a66-a510-34d62b5c4b64 | BDO.InFocusPage |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/BDO-Digital | 09a482dc-d960-4744-b7c9-89b380ebe0e7 | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/Global-forensics | cc75d855-d2d7-42f7-af2a-1fd617cf1648 | BDO.Insight |
| /საქართველოში/Advisory/Global-forensics | de935013-7ff4-44cb-8826-473d14f12797 | BDO.Insight |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `contributors` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/MV-Business-Line/MV-Service-area | bd0fd333-660d-4d49-8923-087362394357 | BDO.ExternalPerson |
| /საქართველოში/MV-Business-Line/MV-Service-area | 3d298fc6-9658-4732-9d2d-c68466b5c897 | BDO.ExternalPerson |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/MV-Bussiness-line/MV-Ordering-demo | db20994b-9b17-45aa-acd1-fc6221652c80 | BDO.Person |
| /Advisory/MV-Bussiness-line/MV-Ordering-demo | 38349a1e-a9bf-4575-a0a5-e7cc2c74f04b | BDO.Person |
| /საქართველოში/MV-Business-Line/MV-Service-area | 6cb0084a-e64a-4e87-93cc-55b15ccf7340 | BDO.Person |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (10 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory/Actuarial-Services | 0cec9a62-cc4e-4ba6-b0f1-ae6c49136b48 | BDO.Industry |
| /Advisory/Advisory/Actuarial-Services | 03b7bec7-c64a-4c27-9ff5-7074260b1ad0 | BDO.Industry |
| /საქართველოში/Advisory/Global-forensics | 8abc7886-c5d2-4c96-bd6a-27771b3334e3 | BDO.BusinessLine |
| /საქართველოში/Advisory/Global-forensics | 731a2043-e3e2-49de-84c4-c93d371ae4aa | BDO.BusinessLine |
| /საქართველოში/Advisory/Global-forensics | 673b0177-8e1c-4de7-992a-ddffc8ea7e95 | BDO.BusinessLine |
| /საქართველოში/Audit-Assurance/IT-Risk-Advisory | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital/Financial-Services | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /საქართველოში/BDO-Digital/Financial-Services | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |
| /საქართველოში/BDO-Digital/Financial-Services | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /საქართველოში/BDO-Digital/Financial-Services | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `backgroundImages` — MediaFilesSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Sustainability-and-ESG/ESG-Assurance | 2563ed68-00e3-4e8e-94b3-17b658c363d0 | _(media file)_ |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 4d0eb532-a0d7-488a-9e6b-78b1d5e35165 | _(media file)_ |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 48864286-9ace-4eea-b58f-ece9b696ed41 | _(media file)_ |

##### Widget References

**`BDO.Widget.TiledLinkSection`** — property `tilePages` — PageSelector (20 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Sustainability-and-ESG/ESG-Assurance | 4f5d04d2-f99c-4784-b59a-8c69a2588191 | BDO.IndustryService |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | cca529eb-c878-4705-8899-ae0ab198cf52 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 8a2a15c7-2a87-4ecf-90c8-077ab0aac72a | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | bd3504b0-5d67-4517-8a23-2ef5d99267b9 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 27e19bc8-ff0c-47ff-97fc-67ca6f2b8e51 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 0760da11-57b1-4820-bd4a-d09d804f8a77 | BDO.IndustryCategory |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | 9eb9fcee-d106-4d09-8acd-5eb07f39e6ca | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital/Financial-Services | ecb844e3-13ef-4fb1-ab5c-e22d5e72d575 | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital/Financial-Services | b3251c61-39a9-4b8f-945a-89150cf5a60b | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital/Financial-Services | 1e6d3ec4-f8ad-4efb-8906-af1daafaa07a | BDO.IndustryCategory |
| /საქართველოში/BDO-Digital/Financial-Services | 4449622b-7291-4961-86bf-3c8e7f70f945 | BDO.IndustryCategory |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | 236c6521-7197-448e-84e5-647b57c11e50 | BDO.Service |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | 0619c385-dc04-4e20-9124-2ba60a1cc9bc | BDO.Service |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | cd88049a-ba1d-4459-a1a7-cad5c2e85a64 | BDO.ServiceArea |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | 02b74919-e6e7-4109-9eed-a59036a82f54 | BDO.Service |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | debab297-5bd7-465c-9543-4d5bbaa86796 | BDO.ServiceArea |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (27 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/Global-forensics | 01576354-9d31-41d4-9cea-94ab15971c1c | — |
| /საქართველოში/Advisory/Global-forensics | 3c94e709-7f73-4fef-9753-386177a8709d | BDO.Insight |
| /საქართველოში/Advisory/Global-forensics | c8b2d233-8cef-4916-8fe6-d9d4a14d86b9 | BDO.Insight |
| /საქართველოში/Advisory/Global-forensics | 3ea0f6b1-b837-4f02-9ab5-a8d39f7606e1 | BDO.Insight |
| /საქართველოში/Advisory/Risk-Advisory-Services | 971ea600-8766-4645-a202-389d9d172afb | BDO.BlogPost |
| /საქართველოში/Advisory/Risk-Advisory-Services | 10de2fed-c971-48a0-b2e9-697cd78446eb | BDO.BlogPost |
| /საქართველოში/Advisory/Risk-Advisory-Services | 9044f6df-050c-4789-8688-c8133a2fe939 | BDO.Person |
| /საქართველოში/Advisory/Risk-Advisory-Services | d69ef2ff-d8a9-45e7-bdd8-6dad0c91f432 | BDO.Person |
| /საქართველოში/Advisory/Risk-Advisory-Services | 12549a84-7817-4d0d-8dbd-eb2b50774b19 | BDO.Insight |
| /საქართველოში/Advisory/Risk-Advisory-Services | ee0e92ed-d0b0-49da-b35b-5a914bed3bc4 | BDO.Insight |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | beb65c42-85fa-4de9-b948-e7429f9a247d | BDO.Blog |
| /საქართველოში/Sustainability-and-ESG/Climate-Mitigation | a1d012b5-4611-4234-abc8-23cdacaad082 | BDO.Blog |
| /საქართველოში/BDO-Digital/Financial-Services | 85db7fa2-29f4-45d7-9f28-51691135a3ca | BDO.Blog |
| /საქართველოში/BDO-Digital/Financial-Services | cc643605-70f1-4005-924d-3396573339e6 | BDO.Blog |
| /საქართველოში/BDO-Digital/Financial-Services | a1d012b5-4611-4234-abc8-23cdacaad082 | BDO.Blog |
| /საქართველოში/BDO-Digital/Financial-Services | 120028e0-833f-4389-9ee7-e8bf961a8942 | BDO.Blog |
| /საქართველოში/BDO-Digital/Financial-Services | 4a5272d0-74ac-439e-861d-e3b4ba24dcd4 | BDO.Insight |
| /საქართველოში/BDO-Digital/Financial-Services | 304f6125-4687-4aa8-97dc-fdbe9e3720a7 | — |
| /საქართველოში/BDO-Digital/Financial-Services | 2b7378e8-f871-48d0-9a1e-e5484f11f204 | — |
| /საქართველოში/BDO-Digital/Financial-Services | bf8a4a0f-d44b-4c19-b523-0c2a2f929e9e | — |
| /საქართველოში/BDO-Digital/Financial-Services | 6ffc2621-99bf-48e8-9826-7d3cb66fe07e | BDO.Insight |
| /საქართველოში/BDO-Digital/Financial-Services | b29ea8c4-d657-470e-b33b-4cb06122ace6 | — |
| /საქართველოში/Consulting-Unternehmensberatung/Service-Area-2 | 780b9e8b-b33f-486b-af21-81994d941788 | BDO.Insight |
| /საქართველოში/Consulting-Unternehmensberatung/Service-Area-2 | 1561c732-411c-4b85-8b7d-cb04c2b1d365 | BDO.Insight |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | e3694ec2-576e-41b5-85a0-d4060c70a659 | BDO.Service |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | bda4c413-ba1f-4d9a-a6a7-18749f765294 | BDO.ServiceArea |
| /საქართველოში/Demo-Business-line/Demo-Service-Area | 236c6521-7197-448e-84e5-647b57c11e50 | BDO.Service |

#### BDO.SpecialtiesArea

##### Widget References

**`BDO.Widget.EditorsPick`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties/BDO-Digital/Cybersecurity | 3d0bb4ac-cb33-4435-84d7-22b585140fc7 | _(media file)_ |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `featuredPages` — PageSelector (3 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties/BDO-Digital/Cybersecurity | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Specialties/BDO-Digital/Cybersecurity | db7e19bb-1157-40a0-a745-dece2e0afb6b | BDO.Insight |
| /Specialties/BDO-Digital/Cybersecurity | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.EditorsPick`** — property `pages` — PageSelector (8 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties/BDO-Digital/Cybersecurity | ceaffb07-91b1-4dcc-a3bb-1d4dadb0966d | BDO.Insight |
| /Specialties/BDO-Digital/Cybersecurity | df050187-62cd-455f-9ccb-027857c84291 | BDO.BlogPost |
| /Specialties/BDO-Digital/Cybersecurity | 049be50c-155f-4178-aab0-9161b834d018 | BDO.MicrositePage |
| /Specialties/BDO-Digital/Cybersecurity | d966d68d-78eb-4c60-b039-6f8db01910f4 | BDO.MicrositePage |
| /Specialties/BDO-Digital/Cybersecurity | c36faab7-1a2d-4ffa-a024-4530ef18dca3 | BDO.NewsArticle |
| /Specialties/BDO-Digital/Cybersecurity | 53b8c1f0-2431-4e89-8046-cac4049166f7 | BDO.Event |
| /Specialties/BDO-Digital/Cybersecurity | b939d30d-2aae-491b-9c72-2c1df7432071 | BDO.Webinar |
| /Specialties/BDO-Digital/Cybersecurity | c92c6197-047b-4ec9-9863-efccea5769fb | BDO.Person |

##### Widget References

**`BDO.Widget.KeyContacts`** — property `people` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties/Category/KR-Speialties | 4d7f7bd6-d53a-4c66-b524-5c4c99e160f1 | BDO.Person |
| /Specialties/Category/KR-Speialties | 9da31a6e-d00b-49c1-bff1-6f4a0601dbc6 | BDO.Person |

#### BDO.SpecialtiesCategory

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties/BDO-Digital | 8cd87001-390c-42d0-ad5c-cba370d32375 | BDO.IndustryService |
| /Specialties/BDO-Digital | 68d1d4f2-a5da-42c4-918a-2c1fc5ac89e4 | BDO.IndustryService |

#### BDO.SpecialtiesPage

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Specialties/Category/Specialties-areas/RK-Specialty-page | 6c422449-b4e9-4e68-8fb5-c8e7215eed2a | BDO.SpecialtiesCategory |

#### BDO.StatusCode

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Error-Pages/500-Internal-Server-Error | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

#### BDO.Subscribe

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Subscribe | 19fb392c-bed1-468b-9186-d2861f5d8a8e | _(media file)_ |

#### BDO.SubService

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/Sub-Service | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.FlexibleContent`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service | 0f32d6f7-dcf2-4c8e-a0cc-f7f40e43b043 | BDO.Insight |
| /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service | d898825a-0c35-467a-8c1b-7de4bc0dde60 | BDO.ServiceArea |

##### Widget References

**`BDO.Widget.TabAccordion`** — property `pages` — PageSelector (2 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service | e4d57642-e0e5-45c5-a323-be8fda5d2c01 | BDO.IndustryService |
| /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service | edceb2e9-33e5-45e7-a1dc-ee7d9aa7b2d0 | BDO.IndustryService |

##### Widget References

**`BDO.Widget.TrendingTopicsCarousel`** — property `pages` — PageSelector (6 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service | e4d57642-e0e5-45c5-a323-be8fda5d2c01 | BDO.IndustryService |
| /Advisory/Advisory/BDO-Digital/BDO-Digital-Service/BDO-Digital-Sub-Service | edceb2e9-33e5-45e7-a1dc-ee7d9aa7b2d0 | BDO.IndustryService |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/Sub-Service | cb7d20d7-9046-4b22-8285-b9af87cc659c | BDO.SpecialtiesCategory |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/Sub-Service | 6c422449-b4e9-4e68-8fb5-c8e7215eed2a | BDO.SpecialtiesCategory |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/Sub-Service | f236f708-58a6-4e63-950a-b066c50a53a9 | BDO.SpecialtiesCategory |
| /საქართველოში/Advisory/Global-forensics/Corruption,-Financial-Reporting-Fraud-Investigatio/Sub-Service | a3a5e5e8-cfe4-4522-bb5e-ee767c9ec66e | BDO.SpecialtiesCategory |

#### BDO.ThankYouConversionPage

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies/thank-(1)/you | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `backgroundImages` — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Gated-downloads/Download-the-report | 4d0eb532-a0d7-488a-9e6b-78b1d5e35165 | _(media file)_ |

##### Widget References

**`BDO.Widget.InsightCarousel`** — property `featuredInsights` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Industries/Gated-downloads/Download-the-report | b560c076-145d-4d34-8d70-bc356fe05199 | BDO.Insight |

#### BDO.ThankYouConversionPages

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Business-Strategies/Thank | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

#### BDO.Webinar

##### Page Type Field References

**property `MetadataTeaserImage`** — MediaFilesSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Events/Lape-Webinar | 07cfab5a-ea8b-4ade-9e3c-a3f4a4fecf20 | _(media file)_ |

##### Widget References

**`BDO.Widget.EventsWebinarsSlider`** — property `featuredEventsAndWebinars` — PageSelector (1 references)

| Source Path | Target Path / GUID | Target Page Type |
| ----------- | ------------------ | ---------------- |
| /Events/EV-Webinar-1 | 4c09ad92-7a5e-44d8-af13-0cb7ea8152d2 | BDO.Webinar |

---

## Relationships

_No page relationships found_

---

## Custom Modules & Classes

### BDO — _BDO_

#### BDO.LinkedPages — _LinkedPages_

- **Coupled table:** `BDO_LinkedPages`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | LinkedPagesID | LinkedPagesID | integer | No | — | — |
| 2 | LinkedPagesName | Name | text(200) | No | TextBoxControl | — |
| 3 | LinkedPagesCodeName | Code name | text(200) | No | CodeName | — |
| 4 | LinkedPagesCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | LinkedPagesNodeId | Node ID | integer | No | TextBoxControl | — |
| 6 | LinkedPagesPeopleID | LinkedPagesPeopleID | text(200) | No | TextBoxControl | — |
| 7 | LinkedPagesNodeGUID | Node GUID | guid | No | TextBoxControl | — |
| 8 | LinkedPagesAfterImportNodeIDs | IDs after import | integer | No | TextBoxControl | — |
| 9 | LinkedPagesAfterImportPeopleIDs | LinkedPagesAfterImportPeopleIDs | text(200) | No | TextBoxControl | — |
| 10 | LinkedPagesClassname | LinkedPagesClassname | text(200) | No | TextBoxControl | — |
| 11 | LinkedPagesSiteID | — | integer | No | — | — |
| 12 | LinkedPagesGuid | GUID | guid | No | — | — |
| 13 | LinkedPagesLastModified | Last modified | datetime | No | — | — |

#### BDO.PeopleSort — _People Sort_

- **Coupled table:** `BDO_PeopleSort`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | PeopleSortID | PeopleSortID | integer | No | — | — |
| 2 | PeopleSortGuid | GUID | guid | No | — | — |
| 3 | PeopleSortLastModified | Last modified | datetime | No | — | — |
| 4 | PeopleSort_SiteID | — | integer | No | — | — |
| 5 | PeopleSort_NodeGuid | — | guid | No | — | — |
| 6 | PeopleSort_PeopleNodeGuid | — | guid | No | — | — |
| 7 | PeopleSort_SortOrder | — | integer | No | — | — |
| 8 | PeopleSort_CultureCode | — | text(200) | No | — | — |

### BDO Central Repository — _BDO.CentralRepository_

#### BDO.CentralRepositoryDeletedDocument — _Deleted Document_

- **Coupled table:** `BDO_CentralRepositoryDeletedDocuments`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | DeletedDocumentID | DeletedDocumentID | integer | No | — | — |
| 2 | DeletedDocumentGuid | GUID | guid | No | — | — |
| 3 | DeletedDocumentPageType | — | text(100) | No | — | — |
| 4 | DeletedDocumentLastModified | Last modified | datetime | No | — | — |
| 5 | DeletedDocumentSiteID | — | integer | No | — | — |
| 6 | DeletedDocumentSiteName | — | text(100) | No | — | — |

#### BDO.CentralRepositoryInsight — _BDO - Insight_

- **Coupled table:** `BDO_CentralRepositoryInsights`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | InsightID | InsightID | integer | No | — | — |
| 2 | Title | — | text(200) | No | — | — |
| 3 | Culture | — | text(200) | No | — | — |
| 4 | DateFirstShared | — | datetime | No | — | — |
| 5 | CountryInvolved | — | text(200) | No | — | — |
| 6 | ServiceLines | — | text(200) | No | — | — |
| 7 | Industries | — | text(200) | No | — | — |
| 8 | OriginalSiteGuid | — | guid | No | — | — |
| 9 | OriginalDocumentGuid | — | guid | No | — | — |
| 10 | OriginalDocumentOwnerName | — | text(200) | No | — | — |
| 11 | OriginalDocumentOwnerEmail | — | text(200) | No | — | — |
| 12 | OriginalDocumentOwnerOptOut | — | boolean | No | — | — |
| 13 | SourceSiteGuid | — | guid | No | — | — |
| 14 | SourceSiteName | — | text(200) | No | — | — |
| 15 | SourceDocumentGuid | — | guid | No | — | — |
| 16 | SourceLastModified | — | datetime | No | — | — |
| 17 | Url | — | text(2000) | No | — | — |
| 18 | InsightsCodeName | — | text(200) | No | — | — |
| 19 | Description | — | longtext | No | — | — |
| 20 | OriginalInsightIsNotPublished | — | boolean | No | — | — |
| 21 | InsightGuid | GUID | guid | No | — | — |
| 22 | InsightLastModified | Last modified | datetime | No | — | — |
| 23 | SharingInstructions | — | text(4000) | No | — | — |
| 24 | SharingHeadline | Check box | boolean | No | CheckBoxControl | — |

#### BDO.CentralRepositoryMyInsight — _Copied Insight_

- **Coupled table:** `BDO_CentralRepositoryMyInsights`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | MyInsightID | MyInsightID | integer | No | — | — |
| 2 | MyInsightGuid | GUID | guid | No | — | — |
| 3 | MyInsightLastModified | Last modified | datetime | No | — | — |
| 4 | InsightID | Insight ID | integer | No | TextBoxControl | — |
| 5 | SiteName | Site name | text(200) | No | TextBoxControl | — |
| 6 | SiteGuid | Site GUID | guid | No | LabelControl | — |
| 7 | CreatedBy | Created by | text(200) | No | TextBoxControl | — |
| 8 | PublicationStatus | Publication status | text(200) | No | TextBoxControl | — |
| 9 | Culture | Culture | text(200) | No | TextBoxControl | — |
| 10 | LastModified | Last modified | datetime | No | CalendarControl | — |
| 11 | OriginalInsightTitle | Original insight title | text(500) | No | TextBoxControl | — |
| 12 | OriginalDocumentGuid | — | guid | No | LabelControl | — |
| 13 | OriginalCulture | — | text(200) | No | TextBoxControl | — |

### BDO GDPR — _BDO.GDPR_

#### BDO.GDPRConsent — _BDO GDPR Consent_

- **Coupled table:** `BDO_GDPRConsent`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GDPR_ConsentID | GDPR_ConsentID | integer | No | — | — |
| 2 | GDPR_ConsentGuid | GUID | guid | No | — | — |
| 3 | ConsentContent | Consent text | longtext | No | HtmlAreaControl | — |
| 4 | ConsentSiteID | — | integer | No | — | — |
| 5 | ConsentCulture | — | text(10) | No | — | — |
| 6 | GDPR_ConsentLastModified | Last modified | datetime | No | — | — |

#### BDO.GDPRContact — _BDO GDPR Contact_

- **Coupled table:** `BDO_GDPRContact`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GDPRContactID | GDPRContactID | integer | No | — | — |
| 2 | GDPRContactGuid | GUID | guid | No | — | — |
| 3 | GDPRContactLastModified | Last modified | datetime | No | — | — |
| 4 | EmailAddress | Email address | text(200) | No | TextBoxControl | — |
| 5 | LastModifiedBy | — | text(200) | No | — | — |

#### BDO.GDPRDeleteLog — _BDO GDPR Delete Count_

- **Coupled table:** `BDO_GDPRDeleteLog`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GDPRDeleteLogID | GDPRDeleteLogID | integer | No | — | — |
| 2 | GDPRDeleteLogGuid | GUID | guid | No | — | — |
| 3 | GDPRDeleteLogLastModified | Last modified | datetime | No | — | — |
| 4 | SiteID | — | integer | No | DropDownListControl | — |
| 5 | SanitizeCount | — | integer | No | TextBoxControl | — |

### BDO API permissions — _BDOAPIPermissions_

#### BDOAPIPermissions.ApiMethodGroup — _API method groups_

- **Coupled table:** `BDOAPIPermissions_ApiMethodGroup`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ApiMethodGroupID | ApiMethodGroupID | integer | No | — | — |
| 2 | ApiMethodGroupGuid | GUID | guid | No | — | — |
| 3 | Name | — | text(200) | No | TextBoxControl | — |
| 4 | DisplayName | — | text(200) | No | TextBoxControl | — |
| 5 | Description | — | longtext | No | HtmlAreaControl | — |
| 6 | OnlyForGlobalAdmins | — | boolean | No | — | — |

#### BDOAPIPermissions.UserApiPermission — _User API Permission_

- **Coupled table:** `BDOAPIPermissions_UserApiPermission`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | UserApiPermissionID | UserApiPermissionID | integer | No | — | — |
| 2 | UserID | — | integer | No | TextBoxControl | — |
| 3 | SiteID | — | integer | No | TextBoxControl | — |
| 4 | ApiMethodGroupID | — | integer | No | TextBoxControl | — |
| 5 | AllowRead | — | boolean | No | — | — |
| 6 | AllowManage | — | boolean | No | CheckBoxControl | — |
| 7 | UserApiPermissionGuid | GUID | guid | No | — | — |
| 8 | UserApiPermissionLastModified | Last modified | datetime | No | — | — |

### BDO Audit Log — _BDOAuditLog_

#### BDOAuditLog.AuditLog — _Audit log_

- **Coupled table:** `BDOAuditLog_AuditLog`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | AuditLogID | AuditLogID | integer | No | — | — |
| 2 | AuditLogGuid | GUID | guid | No | — | — |
| 3 | Time | — | datetime | No | — | — |
| 4 | Username | — | text(200) | No | — | — |
| 5 | UserId | — | integer | No | — | — |
| 6 | IPAddress | — | text(100) | No | TextBoxControl | — |
| 7 | Source | — | text(200) | No | TextBoxControl | — |
| 8 | Action | — | text(6) | No | — | — |
| 9 | ObjectIdentifier | — | text(200) | No | — | — |
| 10 | Description | — | longtext | No | — | — |

### BDO Deal Cards — _BDODealCards_

#### BDODealCards.DealType — _Deal Type_

- **Coupled table:** `BDODealCards_DealType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | DealTypeID | DealTypeID | integer | No | — | — |
| 2 | DealTypeName | Name | text(200) | No | TextBoxControl | — |
| 3 | DealTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | DealTypeCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | DealTypeSiteID | — | integer | No | — | — |
| 6 | DealTypeGuid | GUID | guid | No | — | — |
| 7 | DealTypeLastModified | Last modified | datetime | No | — | — |

#### BDODealCards.GlobalDealType — _Global Deal Type_

- **Coupled table:** `BDODealCards_GlobalDealType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GlobalDealTypeID | GlobalDealTypeID | integer | No | — | — |
| 2 | GlobalDealTypeName | Name | text(200) | No | TextBoxControl | — |
| 3 | GlobalDealTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | GlobalDealTypeGuid | GUID | guid | No | — | — |
| 5 | GlobalDealTypeLastModified | Last modified | datetime | No | — | — |

#### BDODealCards.GlobalIndustry — _Global Industry_

- **Coupled table:** `BDODealCards_GlobalIndustry`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GlobalIndustryID | GlobalIndustryID | integer | No | — | — |
| 2 | GlobalIndustryName | Name | text(200) | No | TextBoxControl | — |
| 3 | GlobalIndustryCodeName | Code name | text(200) | No | CodeName | — |
| 4 | GlobalIndustryGuid | GUID | guid | No | — | — |
| 5 | GlobalIndustryLastModified | Last modified | datetime | No | — | — |

#### BDODealCards.GlobalSubIndustry — _Global Sub-Industry_

- **Coupled table:** `BDODealCards_GlobalSubIndustry`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | GlobalSubIndustryID | GlobalSubIndustryID | integer | No | — | — |
| 2 | GlobalSubIndustryName | Name | text(200) | No | TextBoxControl | — |
| 3 | GlobalSubIndustryCodeName | Code name | text(200) | No | CodeName | — |
| 4 | GlobalSubIndustryRelated | Global industry | text(200) | No | DropDownListControl | — |
| 5 | GlobalSubIndustryGuid | GUID | guid | No | — | — |
| 6 | GlobalSubIndustryLastModified | Last modified | datetime | No | — | — |

#### BDODealCards.Industry — _Industry_

- **Coupled table:** `BDODealCards_Industry`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | IndustryID | IndustryID | integer | No | — | — |
| 2 | IndustryName | Name | text(200) | No | TextBoxControl | — |
| 3 | IndustryCodeName | Code name | text(200) | No | CodeName | — |
| 4 | IndustryCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | IndustrySiteID | — | integer | No | — | — |
| 6 | IndustryGuid | GUID | guid | No | — | — |
| 7 | IndustryLastModified | Last modified | datetime | No | — | — |

#### BDODealCards.Range — _Range_

- **Coupled table:** `BDODealCards_Range`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | RangeID | RangeID | integer | No | — | — |
| 2 | RangeValue | Value | text(200) | No | TextBoxControl | — |
| 3 | RangeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | RangeOrder | — | integer | No | TextBoxControl | — |
| 5 | RangeSiteID | — | integer | No | — | — |
| 6 | RangeGuid | GUID | guid | No | — | — |
| 7 | RangeLastModified | Last modified | datetime | No | — | — |

#### BDODealCards.SubIndustry — _Sub-Industry_

- **Coupled table:** `BDODealCards_SubIndustry`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SubIndustryID | SubIndustryID | integer | No | — | — |
| 2 | SubIndustryName | Name | text(200) | No | TextBoxControl | — |
| 3 | SubIndustryCodeName | Code name | text(200) | No | CodeName | — |
| 4 | SubIndustryCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | SubIndustryRelated | Industry | text(200) | No | DropDownListControlUpdatepanel | — |
| 6 | SubIndustrySiteID | — | integer | No | — | — |
| 7 | SubIndustryGuid | GUID | guid | No | — | — |
| 8 | SubIndustryLastModified | Last modified | datetime | No | — | — |

### BDO Events — _BDOEvents_

#### BDO.EventRegistration — _Event registration_

- **Coupled table:** `BDO_EventRegistration`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | EventRegistrationID | EventRegistrationID | integer | No | — | — |
| 2 | Codename | — | text(200) | No | CodeName | — |
| 3 | EventGUID | — | guid | No | DropDownListControl | — |
| 4 | Status | Status | text(20) | No | DropDownListControl | — |
| 5 | UserGUID | User | guid | No | LabelControl | — |
| 6 | EventRegistrationGUID | GUID | guid | No | — | — |
| 7 | EventRegistrationLastModified | Last modified | datetime | No | — | — |
| 8 | SiteID | — | integer | No | — | — |

### BDO Hosting — _BDOHosting_

#### BDOHosting.HostedFile — _Hosted File_

- **Coupled table:** `BDOHosting_HostedFile`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | HostedFileID | HostedFileID | integer | No | — | — |
| 2 | HostedFileRelativePath | Relative file path | text(200) | No | TextBoxControl | — |
| 3 | HostedFileContentType | Content type | text(200) | No | DropDownListControl | — |
| 4 | HostedFileContentCharset | Character set | text(200) | No | DropDownListControl | — |
| 5 | HostedFileContentDisposition | Content disposition | text(200) | No | DropDownListControl | — |
| 6 | HostedFileContentBody | Content | longtext | No | TextAreaControl | — |
| 7 | HostedFileSiteID | — | integer | No | — | — |
| 8 | HostedFileGuid | GUID | guid | No | — | — |
| 9 | HostedFileLastModified | Last modified | datetime | No | — | — |

### BDO Integrations — _BDOIntegrations_

#### BDOIntegrations.FormSubmissionSubscription — _Form submission subscription_

- **Coupled table:** `BDOIntegrations_FormSubmissionSubscription`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | FormSubmissionSubscriptionID | FormSubmissionSubscriptionID | integer | No | — | — |
| 2 | FormSubmissionSubscriptionGuid | GUID | guid | No | — | — |
| 3 | FormSubmissionSubscriptionLastModified | Last modified | datetime | No | — | — |
| 4 | SiteID | — | integer | No | — | — |
| 5 | DisplayName | Display name | text(200) | No | TextBoxControl | — |
| 6 | CodeName | Code name | text(200) | No | CodeName | — |
| 7 | Description | Description | longtext | No | TextAreaControl | — |
| 8 | Form | Form | text(200) | No | ObjectSelector |  → cms.form |
| 9 | Endpoint | Endpoint | longtext | No | TextBoxControl | — |
| 10 | Method | Method | text(200) | No | DropDownListControl | — |
| 11 | UseAuthorization | Use authorization | boolean | No | CheckBoxControl | — |
| 12 | Scheme | Scheme | text(200) | No | RadioButtonsControl | — |
| 13 | Username | Username | text(200) | No | TextBoxControl | — |
| 14 | EncryptedPassword | Password | text(200) | No | EncryptedSecret | — |
| 15 | RequestContentType | Request content type | text(200) | No | DropDownListControl | — |
| 16 | RequestBodyFormat | Request body format | longtext | No | TextAreaControl | — |

**References:**
- `Form` → `cms.form` ()

### BDO Metadata — _BDOMetadata_

#### BDOMetadata.BusinessIssue — _Business issue_

- **Coupled table:** `BDOMetadata_BusinessIssue`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | BusinessIssueID | BusinessIssueID | integer | No | — | — |
| 2 | BusinessIssueName | Name | text(200) | No | TextBoxControl | — |
| 3 | BusinessIssueCodeName | Code name | text(200) | No | CodeName | — |
| 4 | BusinessIssueCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | BusinessIssueSiteID | — | integer | No | — | — |
| 6 | BusinessIssueGuid | GUID | guid | No | — | — |
| 7 | BusinessIssueLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.CareerEmploymentType — _Career employment type_

- **Coupled table:** `BDOMetadata_CareerEmploymentType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerEmploymentTypeID | CareerEmploymentTypeID | integer | No | — | — |
| 2 | CareerEmploymentTypeName | Name | text(200) | No | TextBoxControl | — |
| 3 | CareerEmploymentTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | CareerEmploymentTypeCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | CareerEmploymentTypeSiteID | — | integer | No | — | — |
| 6 | CareerEmploymentTypeGuid | GUID | guid | No | — | — |
| 7 | CareerEmploymentTypeLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.CareerJobTitle — _Career job title_

- **Coupled table:** `BDOMetadata_CareerJobTitle`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerJobTitleID | CareerJobTitleID | integer | No | — | — |
| 2 | CareerJobTitleName | Name | text(200) | No | TextBoxControl | — |
| 3 | CareerJobTitleCodeName | Code name | text(200) | No | CodeName | — |
| 4 | CareerJobTitleCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | CareerJobTitleSiteID | — | integer | No | — | — |
| 6 | CareerJobTitleGuid | GUID | guid | No | — | — |
| 7 | CareerJobTitleLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.CareerLevel — _Career level_

- **Coupled table:** `BDOMetadata_CareerLevel`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerLevelID | CareerLevelID | integer | No | — | — |
| 2 | CareerLevelName | Name | text(200) | No | TextBoxControl | — |
| 3 | CareerLevelCodeName | Code name | text(200) | No | CodeName | — |
| 4 | CareerLevelCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | CareerLevelSiteID | — | integer | No | — | — |
| 6 | CareerLevelGuid | GUID | guid | No | — | — |
| 7 | CareerLevelLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.CareerType — _Career type_

- **Coupled table:** `BDOMetadata_CareerType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CareerTypeID | CareerTypeID | integer | No | — | — |
| 2 | CareerTypeName | Name | text(200) | No | TextBoxControl | — |
| 3 | CareerTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | CareerTypeCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | CareerTypeSiteID | — | integer | No | — | — |
| 6 | CareerTypeGuid | GUID | guid | No | — | — |
| 7 | CareerTypeLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.ContentType — _Content type_

- **Coupled table:** `BDOMetadata_ContentType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ContentTypeID | ContentTypeID | integer | No | — | — |
| 2 | ContentTypeName | Name | text(200) | No | TextBoxControl | — |
| 3 | ContentTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | ContentTypeCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | ContentTypeSeeAll | See All Text | text(200) | No | TextBoxControl | — |
| 6 | ContentTypeShowSeeAll | Show See All Text | boolean | No | CheckBoxControl | — |
| 7 | ContentTypeSiteID | — | integer | No | — | — |
| 8 | ContentTypeGuid | GUID | guid | No | — | — |
| 9 | ContentTypeLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.Credentials — _Credentials_

- **Coupled table:** `BDOMetadata_Credentials`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | CredentialsID | CredentialsID | integer | No | — | — |
| 2 | CredentialsName | Name | text(200) | No | TextBoxControl | — |
| 3 | CredentialsCodeName | Code name | text(200) | No | CodeName | — |
| 4 | CredentialsCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | CredentialsSiteID | — | integer | No | — | — |
| 6 | CredentialsGuid | GUID | guid | No | — | — |
| 7 | CredentialsLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.EventType — _Event type_

- **Coupled table:** `BDOMetadata_EventType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | EventTypeID | EventTypeID | integer | No | — | — |
| 2 | EventTypeName | Name | text(200) | No | TextBoxControl | — |
| 3 | EventTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | EventTypeCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | EventTypeCallToActionText | Call to action text | text(200) | No | TextBoxControl | — |
| 6 | EventTypeSiteID | — | integer | No | — | — |
| 7 | EventTypeGuid | GUID | guid | No | — | — |
| 8 | EventTypeLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.ProfileGroup — _Profile Group_

- **Coupled table:** `BDOMetadata_ProfileGroup`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ProfileGroupID | ProfileGroupID | integer | No | — | — |
| 2 | ProfileGroupName | Name | text(200) | No | TextBoxControl | — |
| 3 | ProfileGroupCodeName | Code name | text(200) | No | CodeName | — |
| 4 | ProfileGroupCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | ProfileGroupSiteID | — | integer | No | — | — |
| 6 | ProfileGroupGuid | GUID | guid | No | — | — |
| 7 | ProfileGroupLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.ProfileRelationship — _Profile Relationship_

- **Coupled table:** `BDOMetadata_ProfileRelationship`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ProfileRelationshipID | ProfileRelationshipID | integer | No | — | — |
| 2 | ProfileRelationshipName | Name | text(200) | No | TextBoxControl | — |
| 3 | ProfileRelationshipCodeName | Code name | text(200) | No | CodeName | — |
| 4 | ProfileRelationshipCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | ProfileRelationshipSiteID | — | integer | No | — | — |
| 6 | ProfileRelationshipGuid | GUID | guid | No | — | — |
| 7 | ProfileRelationshipLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.RSSCategory — _RSS category_

- **Coupled table:** `BDOMetadata_RSSCategory`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | RSSCategoryID | RSSCategoryID | integer | No | — | — |
| 2 | RSSCategoryName | Name | text(200) | No | TextBoxControl | — |
| 3 | RSSCategoryCodeName | Code name | text(200) | No | CodeName | — |
| 4 | RSSCategoryCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | RSSCategorySiteID | — | integer | No | — | — |
| 6 | RSSCategoryGuid | GUID | guid | No | — | — |
| 7 | RSSCategoryLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.TestimonialClientType — _Testimonial client type_

- **Coupled table:** `BDOMetadata_TestimonialClientType`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TestimonialClientTypeID | TestimonialClientTypeID | integer | No | — | — |
| 2 | ClientTypeName | Client type | text(200) | No | TextBoxControl | — |
| 3 | ClientTypeCodeName | Code name | text(200) | No | CodeName | — |
| 4 | ClientTypeCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | TestimonialClientTypeSiteID | — | integer | No | — | — |
| 6 | TestimonialClientTypeGuid | GUID | guid | No | — | — |
| 7 | TestimonialClientTypeLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.TestimonialIndustry — _Testimonial industry_

- **Coupled table:** `BDOMetadata_TestimonialIndustry`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TestimonialIndustryID | TestimonialIndustryID | integer | No | — | — |
| 2 | IndustryName | Name | text(200) | No | TextBoxControl | — |
| 3 | IndustryCodeName | Code name | text(200) | No | CodeName | — |
| 4 | IndustryCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | TestimonialIndustrySiteID | — | integer | No | — | — |
| 6 | TestimonialIndustryGuid | GUID | guid | No | — | — |
| 7 | TestimonialIndustryLastModified | Last modified | datetime | No | — | — |

#### BDOMetadata.TestimonialServiceLine — _Testimonial service line_

- **Coupled table:** `BDOMetadata_TestimonialServiceLine`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | TestimonialServiceLineID | TestimonialServiceLineID | integer | No | — | — |
| 2 | ServiceLineName | Name | text(200) | No | TextBoxControl | — |
| 3 | ServiceLineCodeName | Code name | text(200) | No | CodeName | — |
| 4 | ServiceLineCultureCode | Language | text(200) | No | SupportedCultureSelector | — |
| 5 | TestimonialServiceLineSiteID | — | integer | No | — | — |
| 6 | TestimonialServiceLineGuid | GUID | guid | No | — | — |
| 7 | TestimonialServiceLineLastModified | Last modified | datetime | No | — | — |

### BDO Release — _BDORelease_

#### BDORelease.UpgradeLog — _Upgrade Log_

- **Coupled table:** `BDORelease_UpgradeLog`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | UpgradeLogID | UpgradeLogID | integer | No | — | — |
| 2 | UpgradeLogGuid | GUID | guid | No | — | — |
| 3 | UpgradeLogLastModified | Last modified | datetime | No | — | — |
| 4 | Type | Type | text(200) | No | DropDownListControl | — |
| 5 | Version | Version | text(20) | No | TextBoxControl | — |
| 6 | Name | Name | text(200) | No | TextBoxControl | — |
| 7 | DateTime | DateTime | datetime | No | CalendarControl | — |
| 8 | State | State | text(20) | No | DropDownListControl | — |
| 9 | Message | Message | longtext | No | HtmlAreaControl | — |

### BDO Settings — _BDOSettings_

#### BDOSettings.FooterLinks — _Footer Links_

- **Coupled table:** `BDOSettings_FooterLinks`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | FooterLinksID | FooterLinksID | integer | No | — | — |
| 2 | FooterLinkTitle | Title | text(200) | No | TextBoxControl | — |
| 3 | FooterLinkUrl | Url | text(500) | No | URLSelector | — |
| 4 | FooterLinkOpenNewWindow | Open in new window | boolean | No | CheckBoxControl | — |
| 5 | FooterLinkCultureCode | Culture | text(20) | No | SupportedCultureSelector | — |
| 6 | FooterLinkOrder | Order | integer | No | NumericUpDown | — |
| 7 | FooterLinksGuid | GUID | guid | No | — | — |
| 8 | FooterLinksLastModified | Last modified | datetime | No | — | — |
| 9 | FooterLinkSiteID | — | integer | No | — | — |

#### BDOSettings.SocialLinks — _Social Links_

- **Coupled table:** `BDOSettings_SocialLinks`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SocialLinksID | SocialLinksID | integer | No | — | — |
| 2 | SocialLinkUrl | Url | text(500) | No | URLSelector | — |
| 3 | SocialLinkAltText | Alt text | text(200) | No | TextBoxControl | — |
| 4 | SocialLinkIconType | Icon type | text(25) | No | DropDownListControl | — |
| 5 | SocialLinkCustomIcon | Custom icon | longtext | No | SvgSelector | — |
| 6 | SocialLinkOrder | Order | integer | No | NumericUpDown | — |
| 7 | SocialLinkAriaLabel | Aria-label | text(200) | No | TextBoxControl | — |
| 8 | SocialLinkCultureCode | Culture | text(20) | No | SupportedCultureSelector | — |
| 9 | SocialLinksGuid | GUID | guid | No | — | — |
| 10 | SocialLinksLastModified | Last modified | datetime | No | — | — |
| 11 | SocialLinkSiteID | — | integer | No | — | — |

### BDO Site Localization — _BDOSiteLocalization_

#### BDOSiteLocalization.DateFormat — _Date Format_

- **Coupled table:** `BDOSiteLocalization_DateFormat`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | DateFormatID | DateFormatID | integer | No | — | — |
| 2 | DateFormatName | Format name | text(200) | No | TextBoxControl | — |
| 3 | DateFormatCodeName | Code name | text(200) | No | CodeName | — |
| 4 | DateFormatCode | Format | text(35) | No | TextBoxControl | — |
| 5 | DateFormatCultureCode | Culture code | text(20) | No | SupportedCultureSelector | — |
| 6 | DateFormatType | — | text(200) | No | — | — |
| 7 | DateFormatSiteID | — | integer | No | TextBoxControl | — |
| 8 | DateFormatGuid | GUID | guid | No | — | — |
| 9 | DateFormatLastModified | Last modified | datetime | No | — | — |

#### BDOSiteLocalization.SiteCultures — _Site Cultures_

- **Coupled table:** `BDOSiteLocalization_SiteCultures`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SiteCulturesID | SiteCulturesID | integer | No | — | — |
| 2 | SiteCultureCode | Site culture | text(20) | No | CultureSelectorForSettings | — |
| 3 | SiteDescription | Description | text(200) | No | TextBoxControl | — |
| 4 | SiteCultureVisible | Visible | boolean | No | CheckBoxControl | — |
| 5 | SelectorAbbreviation | Language selector text | text(10) | No | TextBoxControl | — |
| 6 | SelectorLongForm | Language selector long form text | text(50) | No | TextBoxControl | — |
| 7 | SiteFont | — | text(200) | No | — | — |
| 8 | SiteCultureSiteID | — | integer | No | — | — |
| 9 | SiteCultureItemOrder | — | integer | No | — | — |
| 10 | SiteCulturesGuid | GUID | guid | No | — | — |
| 11 | SiteCulturesLastModified | Last modified | datetime | No | — | — |

#### BDOSiteLocalization.SiteTranslation — _Resource strings_

- **Coupled table:** `BDOSiteLocalization_SiteTranslation`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | SiteTranslationID | SiteTranslationID | integer | No | — | — |
| 2 | SiteTranslationSiteID | — | integer | No | — | — |
| 3 | SiteTranslationStringID | — | integer | No | — | — |
| 4 | SiteTranslationTranslationID | — | integer | No | — | — |
| 5 | SiteTranslationStringKey | — | text(200) | No | — | — |
| 6 | SiteTranslationCultureCode | — | text(50) | No | — | — |
| 7 | SiteTranslationText | Text | text(4000) | No | TextBoxControl | — |
| 8 | SiteTranslationGuid | GUID | guid | No | — | — |
| 9 | SiteTranslationCodeName | — | text(200) | No | — | — |
| 10 | SiteTranslationLastModified | Last modified | datetime | No | — | — |

### XperienceCommunity.UrlRedirection — _URLRedirection_

#### URLRedirection.RedirectionTable — _Redirection Table_

- **Coupled table:** `URLRedirection_RedirectionTable`
- **Parent class:** —

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | RedirectionTableID | RedirectionTableID | integer | No | labelcontrol | — |
| 2 | RedirectionEnabled | Enabled | boolean | No | CheckBoxControl | — |
| 3 | RedirectionOriginalURL | Original URL | text(2000) | No | URLSelector | — |
| 4 | RedirectionExactMatch | Require Exact Match | boolean | No | CheckBoxControl | — |
| 5 | RedirectionTargetURL | Target URL | text(2000) | No | URLSelector | — |
| 6 | RedirectionAppendQueryString | Append Query string | boolean | No | CheckBoxControl | — |
| 7 | RedirectionDescription | Comment | longtext | No | HtmlAreaControl | — |
| 8 | RedirectionSiteID | Site | integer | No | DropDownListControl | — |
| 9 | RedirectionType | Type | text(3) | No | DropDownListControl | — |
| 10 | RedirectionCultures | Redirection Enabled For These Cultures | text(4000) | No | MultipleChoiceControl | — |
| 11 | RedirectionCultureOverride | Culture Override | text(10) | No | Uni_selector |  → cms.culture |
| 12 | RedirectionTableGuid | GUID | guid | No | labelcontrol | — |
| 13 | RedirectionTableLastModified | Last modified | datetime | No | labelcontrol | — |

**References:**
- `RedirectionCultureOverride` → `cms.culture` ()

---

## Custom Tables

### BDO.GlobalLocation — _Global Locations_

- **Coupled table:** `BDO_GlobalLocation`

| # | Field | Caption | Type | Required | Control / Component | Reference |
| --- | ----- | ------- | ---- | -------- | ------------------- | --------- |
| 1 | ItemID | ItemID | integer | No | — | — |
| 2 | MetadataLocationPinColour | — | text(200) | No | DropDownListControl | — |
| 3 | GlobalLocationTitle | Title | text(100) | No | TextBoxControl | — |
| 4 | GlobalLocationAddress1 | Address | text(200) | No | TextBoxControl | — |
| 5 | GlobalLocationAddress2 | Address 2 | text(200) | No | TextBoxControl | — |
| 6 | GlobalLocationCity | City | text(100) | No | TextBoxControl | — |
| 7 | GlobalLocationState | State/Province | text(100) | No | TextBoxControl | — |
| 8 | GlobalLocationCountry | Country | text(255) | No | TextBoxControl | — |
| 9 | GlobalLocationPostalCode | Postal Code | text(20) | No | TextBoxControl | — |
| 10 | GlobalLocationRegion | Region | text(200) | No | DropDownListControl | — |
| 11 | GlobalLocationLatitude | Latitude | decimal(19) | No | TextBoxControl | — |
| 12 | GlobalLocationLongitude | Longitude | decimal(19) | No | TextBoxControl | — |
| 13 | GlobalLocationUrl | URL | text(256) | No | TextBoxControl | — |
| 14 | MemberFirmID | Memberfirm ID | integer | No | TextBoxControl | — |
| 15 | ItemCreatedBy | Created by | integer | No | — | — |
| 16 | ItemCreatedWhen | Created when | datetime | No | — | — |
| 17 | ItemModifiedBy | Modified by | integer | No | — | — |
| 18 | ItemModifiedWhen | Modified when | datetime | No | — | — |
| 19 | ItemOrder | Order | integer | No | — | — |
| 20 | ItemGUID | GUID | guid | No | — | — |

---

## Forms

### Automotive_Report — _Automotive Report_

- **Table:** `Form_Demo_AutomotiveReport`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | AutomotiveReportID | AutomotiveReportID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | First name | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | Last name | text(500) | No | Kentico.TextInput | — | — |
| 6 | CompanyName | Company name | text(500) | No | Kentico.TextInput | — | — |
| 7 | Email | Email | text(500) | No | Kentico.EmailInput | — | — |
| 8 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |

### BDO_ContactPeopleWithEmail — _BDO_ContactPeopleWithEmail_

- **Table:** `Form_Demo_BDO_ContactPeopleWithEmail`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_ContactPeopleWithEmailID | BDO_ContactPeopleWithEmailID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | title | Title | text(500) | No | Kentico.TextInput | — | — |
| 5 | description | Description | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | Email | text(500) | No | Kentico.EmailInput | — | — |

### BDO_ContactPeopleWithSaveUrl — _BDO_ContactPeopleWithSaveUrl_

- **Table:** `Form_Demo_BDO_ContactPeopleWithSaveUrl`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_ContactPeopleWithSaveUrlID | BDO_ContactPeopleWithSaveUrlID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | title | Title | text(500) | No | Kentico.TextInput | — | — |
| 5 | Email | Email | text(500) | No | Kentico.EmailInput | — | — |
| 6 | description | Description | text(500) | No | Kentico.TextInput | — | — |
| 7 | url | URL | text(500) | No | Kentico.TextInput | — | — |

### BDOSwitzerlandForm — _BDO Switzerland Form_

- **Table:** `Form_Demo_BDOSwitzerlandForm`
- **Site:** Demo
- **Submit action:** Thank you for submitting the form.
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDOSwitzerlandFormID | BDOSwitzerlandFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | Email | Email | text(500) | No | Kentico.TextInput | — | — |
| 5 | FirstName | First name | text(500) | No | Kentico.TextInput | — | — |
| 6 | Surname | Surname | text(500) | No | Kentico.TextInput | — | — |
| 7 | Company | Company | text(500) | No | Kentico.TextInput | — | — |
| 8 | Terms | Terms | boolean | No | Kentico.CheckBox | — | — |

### Contact_Us — _Contact us_

- **Table:** `Form_Demo_ContactUs`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | ContactUsID | ContactUsID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$ BDO.KIT.FirstName $} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$ BDO.KIT.LastName $} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$ BDO.KIT.Email $} | text(500) | No | Kentico.EmailInput | — | — |
| 7 | Inquiry | Inquiry | longtext | No | Kentico.TextArea | — | — |
| 8 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 9 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |

### IBOR_Transition_Registration_Form — _IBOR Transition registration form_

- **Table:** `Form_Demo_IBORTransitionRegistrationForm`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | IBORTransitionRegistrationFormID | IBORTransitionRegistrationFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | First name | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | Last name | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | Email | text(500) | No | Kentico.EmailInput | — | — |
| 7 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |

### JobApplications — _Job applications_

- **Table:** `Form_Demo_JobApplications`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | JobApplicationsID | JobApplicationsID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | First name | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | Last name | text(500) | No | Kentico.TextInput | — | — |
| 6 | Seniority | Seniority | text(200) | No | Kentico.DropDown | — | — |
| 7 | CV | CV | bizformfile | No | Kentico.FileUploader | — | — |

### PersonContactForm — _Person contact form_

- **Table:** `Form_Demo_PersonContactForm`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** {% BDO.GetPageColumnValueInForm("PersonEmail") \|(user)Administrator\|(hash)883f360e4d36b4b7200e4d2174514c88dff7338db4b83a64700db91df4ee91d5%}
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | PersonContactFormID | PersonContactFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FormContactGUID | Contact Guid | guid | No | — | — | — |
| 5 | TextInput | Full name | text(500) | No | Kentico.TextInput | — | — |
| 6 | TextArea | Your request | longtext | No | Kentico.TextArea | — | — |
| 7 | BDOConsentAgreement | — | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### SubscribeToNewsletter — _Subscribe to Newsletter_

- **Table:** `Form_Demo_SubscribeToNewsletter`
- **Site:** Demo
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | SubscribeToNewsletterID | SubscribeToNewsletterID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | Name | text(500) | No | Kentico.TextInput | — | — |
| 5 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |
| 6 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |

### BDO_ContactPeopleWithEmail — _BDO_ContactPeopleWithEmail_

- **Table:** `Form_E2E_Performance_BDO_ContactPeopleWithEmail`
- **Site:** E2E & Performance
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_ContactPeopleWithEmailID | BDO_ContactPeopleWithEmailID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### E2EForm — _E2E Form_

- **Table:** `Form_E2E_Performance_E2EForm`
- **Site:** E2E & Performance
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | E2EFormID | E2EFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | firstname | First name | text(500) | No | Kentico.TextInput | — | — |
| 5 | lastname | Last name | text(500) | No | Kentico.TextInput | — | — |
| 6 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |
| 7 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BDO_ContactPeopleWithEmail — _BDO_ContactPeopleWithEmail_

- **Table:** `Form_GWTBDOIndiaTeam_BDO_ContactPeopleWithEmail`
- **Site:** GWT BDO India team
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_ContactPeopleWithEmailID | BDO_ContactPeopleWithEmailID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | Title | Title | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 5 | Description | Description | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 6 | Email | Email | text(500) | No | Kentico.EmailInput | — | — |

### ContactUsTest — _ContactUs test_

- **Table:** `Form_GWTBDOIndiaTeam_ContactUsTest`
- **Site:** GWT BDO India team
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | ContactUsTestID | ContactUsTestID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 5 | TextArea | Text area | longtext | No | Kentico.TextArea | — | — |

### Aa_AaaeOU2c2 — _ÆæÅåÄØ2č2_

- **Table:** `Form_GWT_TST_Aa_AaaeOU2c2`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | Aa_AaaeOU2c2ID | Aa_AaaeOU2c2ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 5 | Recaptcha | reCAPTCHA | text(1) | No | Kentico.Recaptcha | — | — |
| 6 | TextBoxReload | Text Box With Reload | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 7 | DropDown | Drop-down list | text(200) | No | Kentico.DropDown | — | — |
| 8 | CheckBox | Checkbox | boolean | No | Kentico.CheckBox | — | — |
| 9 | TextInput | Text input | text(500) | No | Kentico.TextInput | — | — |

### AaaeOU2c2 — _ÆæÅåÄØ2č2_

- **Table:** `Form_GWT_TST_AaaeOU2c2`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | AaaeOU2c2ID | AaaeOU2c2ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextArea | Text area* | longtext | No | Kentico.TextArea | — | — |
| 5 | Recaptcha | reCAPTCHA | text(1) | No | Kentico.Recaptcha | — | — |

### bdo_contactpeoplewithemail — _Contact People with email_

- **Table:** `Form_GWT_TST_bdo_contactpeoplewithemail`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | bdo_contactpeoplewithemailID | bdo_contactpeoplewithemailID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | Title | Title | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 5 | Description | Description | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 6 | Email | Email | text(500) | No | Kentico.EmailInput | — | — |

### BDO_ContactPeopleWithSaveUrl1 — _Test_BK_

- **Table:** `Form_GWT_TST_BDO_ContactPeopleWithSaveUrl1`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_ContactPeopleWithSaveUrl1ID | BDO_ContactPeopleWithSaveUrl1ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### bdo_contactuswithsaveurl — _Contact us with saveurl_

- **Table:** `Form_GWT_TST_bdo_contactuswithsaveurl`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | bdo_contactuswithsaveurlID | bdo_contactuswithsaveurlID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | Title | Title | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 5 | Description | Description | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 6 | URL | URL | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |

### BDO_EventNode059a439b31db4677b6b3828cd3e158d0 — _19/03/2025-19/05/2025 Event A 17_

- **Table:** `Form_BDO_EventNode059a439b31db4677b6b3828cd3e158d0`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode059a439b31db4677b6b3828cd3e158d0ID | BDO_EventNode059a439b31db4677b6b3828cd3e158d0ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode0902cc03d91a45ccb3bedb6566f7f89f — _09/07/2025-09/07/2025 Testing Hero w banner w CTA 2nd_

- **Table:** `Form_BDO_EventNode0902cc03d91a45ccb3bedb6566f7f89f`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode0902cc03d91a45ccb3bedb6566f7f89fID | BDO_EventNode0902cc03d91a45ccb3bedb6566f7f89fID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode21caf0bfe3f04794a4bd6a9c2b1e4aeb — _19/03/2025-19/05/2025 Event A 1_

- **Table:** `Form_BDO_EventNode21caf0bfe3f04794a4bd6a9c2b1e4aeb`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode21caf0bfe3f04794a4bd6a9c2b1e4aebID | BDO_EventNode21caf0bfe3f04794a4bd6a9c2b1e4aebID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode2525a6f1a8064d59848cdec756735500 — _24/03/2025-24/03/2025 KR 2023 Risk, Resilience & Recovery Webcast_

- **Table:** `Form_BDO_EventNode2525a6f1a8064d59848cdec756735500`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode2525a6f1a8064d59848cdec756735500ID | BDO_EventNode2525a6f1a8064d59848cdec756735500ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode27f0d9686a014d4e8d3e6dac396dd066 — _19/03/2025-19/05/2025 Event A 7_

- **Table:** `Form_BDO_EventNode27f0d9686a014d4e8d3e6dac396dd066`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode27f0d9686a014d4e8d3e6dac396dd066ID | BDO_EventNode27f0d9686a014d4e8d3e6dac396dd066ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode28f41d6fb6084ae9b43269acade88ad2 — _x(DELETED)20/01/2025-20/01/2025 JJ Event _

- **Table:** `Form_BDO_EventNode28f41d6fb6084ae9b43269acade88ad2`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode28f41d6fb6084ae9b43269acade88ad2ID | BDO_EventNode28f41d6fb6084ae9b43269acade88ad2ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode2baf5237d37247a99b4bf94cb75affe7 — _19/03/2025-19/05/2025 Event A 20_

- **Table:** `Form_BDO_EventNode2baf5237d37247a99b4bf94cb75affe7`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode2baf5237d37247a99b4bf94cb75affe7ID | BDO_EventNode2baf5237d37247a99b4bf94cb75affe7ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode32337d94b56a4dd0a211a90fd83433d7 — _07/04/2025-07/04/2025 New Webinar with hero w image_

- **Table:** `Form_BDO_EventNode32337d94b56a4dd0a211a90fd83433d7`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode32337d94b56a4dd0a211a90fd83433d7ID | BDO_EventNode32337d94b56a4dd0a211a90fd83433d7ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode33c6d4b9471941c6a77f5b8147f24510 — _23/09/2024-23/09/2024 Lape Webinar_

- **Table:** `Form_BDO_EventNode33c6d4b9471941c6a77f5b8147f24510`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode33c6d4b9471941c6a77f5b8147f24510ID | BDO_EventNode33c6d4b9471941c6a77f5b8147f24510ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | MonthYear | Month Year | datetime | No | BDO.FormComponent.MonthYear | — | — |

### BDO_EventNode35421dad2aa441a69db4cd1753106207 — _19/03/2025-19/05/2025 Event A 10_

- **Table:** `Form_BDO_EventNode35421dad2aa441a69db4cd1753106207`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode35421dad2aa441a69db4cd1753106207ID | BDO_EventNode35421dad2aa441a69db4cd1753106207ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode357d13de92534c93be4b4186114f11b7 — _04/03/2025-14/07/2025 MV Event_

- **Table:** `Form_BDO_EventNode357d13de92534c93be4b4186114f11b7`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode357d13de92534c93be4b4186114f11b7ID | BDO_EventNode357d13de92534c93be4b4186114f11b7ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |

### BDO_EventNode36537c452cde4c558bdceee90e7be52d — _23/07/2025-31/07/2025 JV Event 2_

- **Table:** `Form_BDO_EventNode36537c452cde4c558bdceee90e7be52d`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode36537c452cde4c558bdceee90e7be52dID | BDO_EventNode36537c452cde4c558bdceee90e7be52dID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode371dfa0b33664d328d5333f1621e3f03 — _11/06/2024-11/06/2024 EV Webinar 1_

- **Table:** `Form_BDO_EventNode371dfa0b33664d328d5333f1621e3f03`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode371dfa0b33664d328d5333f1621e3f03ID | BDO_EventNode371dfa0b33664d328d5333f1621e3f03ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | ReadOnlyTextComponent | Read-only Text Component | longtext | No | ReadOnlyTextComponent | — | — |

### BDO_EventNode3b0dd3a057564f6db12cf95a0062d828 — _23/11/2025-23/11/2025 JJ Event_

- **Table:** `Form_BDO_EventNode3b0dd3a057564f6db12cf95a0062d828`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode3b0dd3a057564f6db12cf95a0062d828ID | BDO_EventNode3b0dd3a057564f6db12cf95a0062d828ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BDO_EventNode3c5dc96a6c6d46dd9d7708516fc7f545 — _04/11/2026-04/11/2026 Event EV 7..6.2_

- **Table:** `Form_BDO_EventNode3c5dc96a6c6d46dd9d7708516fc7f545`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode3c5dc96a6c6d46dd9d7708516fc7f545ID | BDO_EventNode3c5dc96a6c6d46dd9d7708516fc7f545ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BDO_EventNode3d9cb85ff18848fb939007d42a61c13c — _18/09/2030-18/09/2030 Test 1_

- **Table:** `Form_BDO_EventNode3d9cb85ff18848fb939007d42a61c13c`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode3d9cb85ff18848fb939007d42a61c13cID | BDO_EventNode3d9cb85ff18848fb939007d42a61c13cID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 12 | MultipleChoice | Multiple choice | longtext | No | Kentico.MultipleChoice | — | — |
| 13 | RadioButtons | Radio buttons | text(200) | No | Kentico.RadioButtons | — | — |
| 14 | SecurityCode_1 | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 15 | Recaptcha | reCAPTCHA | text(1) | No | Kentico.Recaptcha | — | — |

### BDO_EventNode4604cd48ed9343cb853171517d858ffb — _21/08/2025-21/08/2025 KR 2026 Risk, Resilience & Recovery Webcast_

- **Table:** `Form_BDO_EventNode4604cd48ed9343cb853171517d858ffb`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode4604cd48ed9343cb853171517d858ffbID | BDO_EventNode4604cd48ed9343cb853171517d858ffbID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode468b3faeef57411d887b378fc2700915 — _19/03/2025-19/05/2025 Event A 15_

- **Table:** `Form_BDO_EventNode468b3faeef57411d887b378fc2700915`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode468b3faeef57411d887b378fc2700915ID | BDO_EventNode468b3faeef57411d887b378fc2700915ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode4c09ad927a5e44d8af130cb7ea8152d2 — _06/03/2025-06/03/2025 KR 2023 Risk, Resilience & Recovery Webcast_

- **Table:** `Form_BDO_EventNode4c09ad927a5e44d8af130cb7ea8152d2`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode4c09ad927a5e44d8af130cb7ea8152d2ID | BDO_EventNode4c09ad927a5e44d8af130cb7ea8152d2ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode56430da89c2b4abcaa4bb106a4182cce — _19/03/2025-19/05/2025 Event A 14_

- **Table:** `Form_BDO_EventNode56430da89c2b4abcaa4bb106a4182cce`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode56430da89c2b4abcaa4bb106a4182cceID | BDO_EventNode56430da89c2b4abcaa4bb106a4182cceID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode5b3665745c844d06935ca4c433adcb69 — _19/03/2024-19/05/2024 Event A 16_

- **Table:** `Form_BDO_EventNode5b3665745c844d06935ca4c433adcb69`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode5b3665745c844d06935ca4c433adcb69ID | BDO_EventNode5b3665745c844d06935ca4c433adcb69ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode5b7333b6fdfa47849b5652634f80381b — _09/07/2023-09/07/2023 Testing Hero w banner and image NO CTA_

- **Table:** `Form_BDO_EventNode5b7333b6fdfa47849b5652634f80381b`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode5b7333b6fdfa47849b5652634f80381bID | BDO_EventNode5b7333b6fdfa47849b5652634f80381bID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode5baa971444de4c3cb854ef2d99912023 — _19/09/2025-19/09/2025 JV Event 1_

- **Table:** `Form_BDO_EventNode5baa971444de4c3cb854ef2d99912023`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode5baa971444de4c3cb854ef2d99912023ID | BDO_EventNode5baa971444de4c3cb854ef2d99912023ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode5d436e58919e44dba6075e5a44bb5036 — _19/03/2025-19/05/2025 Event A 2_

- **Table:** `Form_BDO_EventNode5d436e58919e44dba6075e5a44bb5036`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode5d436e58919e44dba6075e5a44bb5036ID | BDO_EventNode5d436e58919e44dba6075e5a44bb5036ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode65fa258c9e4c4c418c5428ea40ea0368 — _19/03/2025-19/05/2025 Event A 20_

- **Table:** `Form_BDO_EventNode65fa258c9e4c4c418c5428ea40ea0368`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode65fa258c9e4c4c418c5428ea40ea0368ID | BDO_EventNode65fa258c9e4c4c418c5428ea40ea0368ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode6af2d096f10b4fe2940e81d591673e4d — _22/08/2025-22/08/2025 JV Event_

- **Table:** `Form_BDO_EventNode6af2d096f10b4fe2940e81d591673e4d`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode6af2d096f10b4fe2940e81d591673e4dID | BDO_EventNode6af2d096f10b4fe2940e81d591673e4dID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode6e7c709545ba4f199edad0e4866d3dda — _19/03/2025-19/05/2025 Event A 12_

- **Table:** `Form_BDO_EventNode6e7c709545ba4f199edad0e4866d3dda`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode6e7c709545ba4f199edad0e4866d3ddaID | BDO_EventNode6e7c709545ba4f199edad0e4866d3ddaID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode71fb958a34ca4b20a0b7b4bdd26f22ae — _19/03/2025-19/05/2025 Event A 19_

- **Table:** `Form_BDO_EventNode71fb958a34ca4b20a0b7b4bdd26f22ae`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode71fb958a34ca4b20a0b7b4bdd26f22aeID | BDO_EventNode71fb958a34ca4b20a0b7b4bdd26f22aeID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Mobile_text | Text input | text(500) | No | Kentico.TextInput | — | — |
| 9 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 11 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode7f0c3897b2d24d159d8d9ac001e4a991 — _09/07/2025-09/07/2025 Testing Hero w Hero w CTA 3rd_

- **Table:** `Form_BDO_EventNode7f0c3897b2d24d159d8d9ac001e4a991`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode7f0c3897b2d24d159d8d9ac001e4a991ID | BDO_EventNode7f0c3897b2d24d159d8d9ac001e4a991ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode8846c15e5c044b01840111058fddeea7 — _19/03/2025-19/05/2025 Event A 18_

- **Table:** `Form_BDO_EventNode8846c15e5c044b01840111058fddeea7`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode8846c15e5c044b01840111058fddeea7ID | BDO_EventNode8846c15e5c044b01840111058fddeea7ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode89534182b6f54d9f8797b0ec1319c012 — _23/06/2024-23/06/2024 KR 2023 State of the Healthcare Industry: Compliance _

- **Table:** `Form_BDO_EventNode89534182b6f54d9f8797b0ec1319c012`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode89534182b6f54d9f8797b0ec1319c012ID | BDO_EventNode89534182b6f54d9f8797b0ec1319c012ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode94806d314d904220af68e642b45a4e2b — _19/03/2025-19/05/2025 Event A 8_

- **Table:** `Form_BDO_EventNode94806d314d904220af68e642b45a4e2b`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode94806d314d904220af68e642b45a4e2bID | BDO_EventNode94806d314d904220af68e642b45a4e2bID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode9c545fb841794e97a13b2b20fcde418d — _05/05/2025-05/05/2025 KR 2023 Risk, Resilience & Recovery Webcast_

- **Table:** `Form_BDO_EventNode9c545fb841794e97a13b2b20fcde418d`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode9c545fb841794e97a13b2b20fcde418dID | BDO_EventNode9c545fb841794e97a13b2b20fcde418dID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNode9de930a6ab16471aaf4c73c7a41a3c80 — _21/11/2024-21/11/2024 Lape Event_

- **Table:** `Form_BDO_EventNode9de930a6ab16471aaf4c73c7a41a3c80`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNode9de930a6ab16471aaf4c73c7a41a3c80ID | BDO_EventNode9de930a6ab16471aaf4c73c7a41a3c80ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodea00a7335729f40958a7244e99c84233f — _19/03/2025-19/05/2025 Event A 4_

- **Table:** `Form_BDO_EventNodea00a7335729f40958a7244e99c84233f`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodea00a7335729f40958a7244e99c84233fID | BDO_EventNodea00a7335729f40958a7244e99c84233fID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodea0438815439145c89f6e78cdc04d0839 — _19/03/2025-19/05/2025 Event A 5_

- **Table:** `Form_BDO_EventNodea0438815439145c89f6e78cdc04d0839`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodea0438815439145c89f6e78cdc04d0839ID | BDO_EventNodea0438815439145c89f6e78cdc04d0839ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodea5d8340f79bc4d44b8baf8ceec8debe6 — _03/11/2025-03/11/2026 Test Fix Event_

- **Table:** `Form_BDO_EventNodea5d8340f79bc4d44b8baf8ceec8debe6`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodea5d8340f79bc4d44b8baf8ceec8debe6ID | BDO_EventNodea5d8340f79bc4d44b8baf8ceec8debe6ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BDO_EventNodeb2d681955e8a48528bde75821c4c722d — _20/03/2025-20/03/2025 Webinar On-Demand_

- **Table:** `Form_BDO_EventNodeb2d681955e8a48528bde75821c4c722d`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodeb2d681955e8a48528bde75821c4c722dID | BDO_EventNodeb2d681955e8a48528bde75821c4c722dID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodeb939d30d2aae491b9c722c1df7432071 — _26/09/2024-26/09/2024 Title_

- **Table:** `Form_BDO_EventNodeb939d30d2aae491b9c722c1df7432071`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodeb939d30d2aae491b9c722c1df7432071ID | BDO_EventNodeb939d30d2aae491b9c722c1df7432071ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodebbece091141443ecbfcff578ab589933 — _19/03/2025-19/05/2025 Event A 11_

- **Table:** `Form_BDO_EventNodebbece091141443ecbfcff578ab589933`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodebbece091141443ecbfcff578ab589933ID | BDO_EventNodebbece091141443ecbfcff578ab589933ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodec615e46f0e6545088c00886451976513 — _x(DELETED)01/10/2024-31/10/2024 Event on-demand_

- **Table:** `Form_BDO_EventNodec615e46f0e6545088c00886451976513`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodec615e46f0e6545088c00886451976513ID | BDO_EventNodec615e46f0e6545088c00886451976513ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodecc46caf812e64b8d9f36c1c6ec78e74b — _19/03/2025-19/05/2025 Event A 13_

- **Table:** `Form_BDO_EventNodecc46caf812e64b8d9f36c1c6ec78e74b`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodecc46caf812e64b8d9f36c1c6ec78e74bID | BDO_EventNodecc46caf812e64b8d9f36c1c6ec78e74bID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodece84fb70112b455eb6477d2ddf78b065 — _28/10/2025-28/10/2026 Jerard Event Test_

- **Table:** `Form_BDO_EventNodece84fb70112b455eb6477d2ddf78b065`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodece84fb70112b455eb6477d2ddf78b065ID | BDO_EventNodece84fb70112b455eb6477d2ddf78b065ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BDO_EventNoded452bc7fe57b40009e12910e074f5281 — _31/03/2025-31/03/2025 Quarterly Technical Update - Q4 2024 (Live Session)_

- **Table:** `Form_BDO_EventNoded452bc7fe57b40009e12910e074f5281`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNoded452bc7fe57b40009e12910e074f5281ID | BDO_EventNoded452bc7fe57b40009e12910e074f5281ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 12 | MonthYear | Month Year | datetime | No | BDO.FormComponent.MonthYear | — | — |

### BDO_EventNoded74d36a0006a41aeb334baf0a3135bb4 — _09/07/2025-09/07/2025 Testing Hero w banner and image w CTA_

- **Table:** `Form_BDO_EventNoded74d36a0006a41aeb334baf0a3135bb4`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNoded74d36a0006a41aeb334baf0a3135bb4ID | BDO_EventNoded74d36a0006a41aeb334baf0a3135bb4ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodee2bf4e2874e14459a76abca8d9f134b5 — _x(DELETED)31/08/2024-31/08/2024 EV Event 2_

- **Table:** `Form_BDO_EventNodee2bf4e2874e14459a76abca8d9f134b5`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodee2bf4e2874e14459a76abca8d9f134b5ID | BDO_EventNodee2bf4e2874e14459a76abca8d9f134b5ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodee54379daf0e34f75b49ffbc668b313df — _19/03/2025-19/05/2025 Event A 3_

- **Table:** `Form_BDO_EventNodee54379daf0e34f75b49ffbc668b313df`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodee54379daf0e34f75b49ffbc668b313dfID | BDO_EventNodee54379daf0e34f75b49ffbc668b313dfID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodee825a689a4ed4c57b5551fb2c5724f56 — _28/01/2025-28/01/2025 Harnessing the power of AI and Microsoft Copilot: Str_

- **Table:** `Form_BDO_EventNodee825a689a4ed4c57b5551fb2c5724f56`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodee825a689a4ed4c57b5551fb2c5724f56ID | BDO_EventNodee825a689a4ed4c57b5551fb2c5724f56ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 12 | MonthYear | Month Year | datetime | No | BDO.FormComponent.MonthYear | — | — |
| 13 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |

### BDO_EventNodef1d26afc8fb844ccabbbc2a1963df576 — _27/02/2026-27/07/2026 Event EV 1_

- **Table:** `Form_BDO_EventNodef1d26afc8fb844ccabbbc2a1963df576`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodef1d26afc8fb844ccabbbc2a1963df576ID | BDO_EventNodef1d26afc8fb844ccabbbc2a1963df576ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |

### BDO_EventNodef7381f343786491abeb4bb5ebba8a6e5 — _19/03/2025-19/05/2025 Event A 9_

- **Table:** `Form_BDO_EventNodef7381f343786491abeb4bb5ebba8a6e5`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodef7381f343786491abeb4bb5ebba8a6e5ID | BDO_EventNodef7381f343786491abeb4bb5ebba8a6e5ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodef7aeb7413bb0436faa6f3b340ae184a4 — _08/04/2024-08/04/2024 VIP Webinar_

- **Table:** `Form_BDO_EventNodef7aeb7413bb0436faa6f3b340ae184a4`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodef7aeb7413bb0436faa6f3b340ae184a4ID | BDO_EventNodef7aeb7413bb0436faa6f3b340ae184a4ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_EventNodef9e76cafb7f64f61a39a15e2f5673ca3 — _18/11/2025-18/11/2025 RK Event_

- **Table:** `Form_BDO_EventNodef9e76cafb7f64f61a39a15e2f5673ca3`
- **Site:** GWT TST
- **Submit action:** Thank you for submitting the form :)
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodef9e76cafb7f64f61a39a15e2f5673ca3ID | BDO_EventNodef9e76cafb7f64f61a39a15e2f5673ca3ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | IntInput | Phone number Numeric input | integer | No | Kentico.IntInput | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BDO_EventNodefe49ef82938b45148c1c58910364152d — _19/03/2025-19/05/2025 Event A 6_

- **Table:** `Form_BDO_EventNodefe49ef82938b45148c1c58910364152d`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_EventNodefe49ef82938b45148c1c58910364152dID | BDO_EventNodefe49ef82938b45148c1c58910364152dID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDO_KIT_ContactPeople — _Contact People NO_

- **Table:** `Form_GWT_TST_BDO_KIT_ContactPeople`
- **Site:** GWT TST
- **Submit action:** Takk for din henvendelse. Jeg vil svare deg så snart jeg kan. success
- **Notification email:** {% BDO.GetPageColumnValueInForm("PersonEmail") \|(user)Administrator\|(hash)883f360e4d36b4b7200e4d2174514c88dff7338db4b83a64700db91df4ee91d5%}
- **Confirmation email:** admin@localhost.local
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDO_KIT_ContactPeopleID | BDO_KIT_ContactPeopleID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | test | {$BDO.KIT.CityState$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | Epost | E-post | text(500) | No | Kentico.EmailInput | — | — |
| 6 | Firma | Firma | text(500) | No | Kentico.TextInput | — | — |
| 7 | CheckBox | — | boolean | No | Kentico.CheckBox | — | — |
| 8 | BDOConsentAgreement_1 | — | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 9 | Recaptcha | reCAPTCHA | text(1) | No | Kentico.Recaptcha | — | — |
| 10 | Etternavn | Etternavn | text(500) | No | Kentico.TextInput | — | — |

### BDOEventTemplate_DoNotModify — _* BDO Event Template (Do Not Modify)_

- **Table:** `Form_GWT_TST_BDOEventTemplate_DoNotModify`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDOEventTemplate_DoNotModifyID | BDOEventTemplate_DoNotModifyID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |
| 11 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### BSIStudioForm — _BSI Studio Form_

- **Table:** `Form_GWT_TST_BSIStudioForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BSIStudioFormID | BSIStudioFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | email | Email | text(500) | No | Kentico.EmailInput | — | — |

### Demo10_10 — _Demo10-10_

- **Table:** `Form_GWT_TST_Demo10_10`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | Demo10_10ID | Demo10_10ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | {$BDO.KIT.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |
| 6 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |

### DemoForm — _Demo form_

- **Table:** `Form_GWT_TST_DemoForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | DemoFormID | DemoFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextArea | Name | longtext | No | Kentico.TextArea | — | — |
| 5 | TextArea_1 | Text area | longtext | No | Kentico.TextArea | — | — |
| 6 | Recaptcha | reCAPTCHA | text(1) | No | Kentico.Recaptcha | — | — |

### DemoToOurGWTFamily — _Demo to our GWT Family_

- **Table:** `Form_GWT_TST_DemoToOurGWTFamily`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** {% BDO.GetPageColumnValueInForm("PersonEmail") \|(user)Administrator\|(hash)883f360e4d36b4b7200e4d2174514c88dff7338db4b83a64700db91df4ee91d5%}
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | DemoToOurGWTFamilyID | DemoToOurGWTFamilyID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | Miestas | text(500) | No | Kentico.TextInput | — | — |
| 5 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |

### DemoToPO — _Demo to PO_

- **Table:** `Form_GWT_TST_DemoToPO`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | DemoToPOID | DemoToPOID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### E2E_694813_ContactForm — _E2E_694813_ContactForm_

- **Table:** `Form_GWT_TST_E2E_694813_ContactForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** edvinas.vasiliauskas@bdo.global
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | E2E_694813_ContactFormID | E2E_694813_ContactFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | E2E_694813_FirstName | First name | text(500) | No | Kentico.TextInput | — | — |
| 5 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |
| 6 | E2E_694813_LastName | Last name | text(500) | No | Kentico.TextInput | — | — |
| 7 | E2E_694813_ConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 8 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |
| 9 | TextInput | PageUrl | text(500) | No | Kentico.TextInput | — | — |

### EV_Form — _EV_Form_

- **Table:** `Form_GWT_TST_EV_Form`
- **Site:** GWT TST
- **Submit action:** Success
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | EV_FormID | EV_FormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | First name | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextInput_1 | Last name | text(500) | No | Kentico.TextInput | — | — |
| 6 | TextArea | Text area | longtext | No | Kentico.TextArea | — | — |
| 7 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### form_96 — _היערכות לקראת תום שנת המס תשפ"ג_

- **Table:** `Form_GWT_TST_form_96`
- **Site:** GWT TST
- **Submit action:** Success
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | form_96ID | form_96ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextBoxControl | שם פרטי* | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextBoxControl_1 | שם משפחה* | text(500) | No | Kentico.TextInput | — | — |
| 6 | TextBoxControl_2 | תפקיד* | text(500) | No | Kentico.TextInput | — | — |
| 7 | TextBoxControl_4 | חברה* | text(500) | No | Kentico.TextInput | — | — |
| 8 | TextBoxControl_3 |   דואר אלקטרוני עסקי* | text(500) | No | Kentico.TextInput | — | — |
| 9 | TextBoxControl_5 | טלפון* | text(500) | No | Kentico.TextInput | — | — |
| 10 | ______________________________________________________BDO__ | אני מסכים\ה לקבלת חומרים שיווקיים, אירועים ודיוורים מ-BDO:* | boolean | No | Kentico.CheckBox | — | — |
| 11 | BdoSecurityCode | {$BDO.KIT.SecurityCode$} | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### FormAfterHotfix — _Form after Hotfix_

- **Table:** `Form_GWT_TST_FormAfterHotfix`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | FormAfterHotfixID | FormAfterHotfixID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### FormAfterHotfix_1 — _Form after Hotfix_

- **Table:** `Form_GWT_TST_FormAfterHotfix_1`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | FormAfterHotfix_1ID | FormAfterHotfix_1ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | USPhone | U.S. phone number | text(14) | No | Kentico.USPhone | — | — |
| 5 | IntInput | Numeric input | integer | No | Kentico.IntInput | — | — |
| 6 | TextArea | Text area | longtext | No | Kentico.TextArea | — | — |

### FormWithAttachement — _Form with attachement_

- **Table:** `Form_GWT_TST_FormWithAttachement`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | FormWithAttachementID | FormWithAttachementID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |

### GatedDownloadsForIndustries — _Gated downloads for Industries_

- **Table:** `Form_GWT_TST_GatedDownloadsForIndustries`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | GatedDownloadsForIndustriesID | GatedDownloadsForIndustriesID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | First name* | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextInput_1 | Last name* | text(500) | No | Kentico.TextInput | — | — |
| 6 | TextInput_2 | Company* | text(500) | No | Kentico.TextInput | — | — |
| 7 | EmailInput | Email* | text(500) | No | Kentico.EmailInput | — | — |

### JobApply — _Job apply_

- **Table:** `Form_GWT_TST_JobApply`
- **Site:** GWT TST
- **Submit action:** Thank you for applying.
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | JobApplyID | JobApplyID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | First Name | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextInput_1 | Last Name | text(500) | No | Kentico.TextInput | — | — |
| 6 | TextInput_2 | Email | text(500) | No | Kentico.TextInput | — | — |
| 7 | FileUploader |  Upload your CV | bizformfile | No | Kentico.FileUploader | — | — |
| 8 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### Lape_Form_2 — _Lape_Form_2_

- **Table:** `Form_GWT_TST_Lape_Form_2`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | Lape_Form_2ID | Lape_Form_2ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | CheckBox | Checkbox | boolean | No | Kentico.CheckBox | — | — |

### LapeForm — _Lape Form_

- **Table:** `Form_GWT_TST_LapeForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** edvinas.vasiliauskas@bdo.global
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | LapeFormID | LapeFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FileUploaderCustom | File uploader custom name | bizformfile | No | Kentico.FileUploader | — | — |
| 5 | FileUploader_1 | File uploader 1 | bizformfile | No | Kentico.FileUploader | — | — |
| 6 | TextArea | Text area | longtext | No | Kentico.TextArea | — | — |
| 7 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |

### LapeForm_1 — _Lape Form_

- **Table:** `Form_GWT_TST_LapeForm_1`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | LapeForm_1ID | LapeForm_1ID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | ReadOnlyTextComponent | Read-only Text Component | longtext | No | ReadOnlyTextComponent | — | — |
| 5 | ReadOnlyTextComponent_1 | Read-only Text Component | longtext | No | ReadOnlyTextComponent | — | — |
| 6 | ReadOnlyTextComponent_2 | Read-only Text Component | longtext | No | ReadOnlyTextComponent | — | — |

### LapeTest — _Lape Test_

- **Table:** `Form_GWT_TST_LapeTest`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | LapeTestID | LapeTestID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### MatasNewForm — _Matas new form_

- **Table:** `Form_GWT_TST_MatasNewForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | MatasNewFormID | MatasNewFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | Text input | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextInput_1 | Text input | text(500) | No | Kentico.TextInput | — | — |

### MyForm — _My Form_

- **Table:** `Form_GWT_TST_MyForm`
- **Site:** GWT TST
- **Submit action:** Thank you for submitting the form :)
- **Notification email:** toma.saltane@bdo.global
- **Confirmation email:** tadas.lape@test.mail
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | MyFormID | MyFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextArea | Tekstas | longtext | No | Kentico.TextArea | — | — |
| 5 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |

### Neliesti — _Neliesti_

- **Table:** `Form_GWT_TST_Neliesti`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** {% BDO.GetPageColumnValueInForm("PersonEmail", "Nepavyko@nepavyko.nepavyko") \|(user)Administrator\|(hash)d3c1ce74d75abf4edec8cf674f11ea4b0c72e75c06b22206df0ed062154fab41%}
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | NeliestiID | NeliestiID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | CheckBox | Checkbox | boolean | No | Kentico.CheckBox | — | — |

### NewAPIForm — _New API Form_

- **Table:** `Form_GWT_TST_NewAPIForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | NewAPIFormID | NewAPIFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | CheckBox | Checkbox | boolean | No | Kentico.CheckBox | — | — |
| 5 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |
| 6 | IntInput | Numeric input | integer | No | Kentico.IntInput | — | — |
| 7 | TextArea | Text area | longtext | No | Kentico.TextArea | — | — |
| 8 | TextInput | Text input | text(500) | No | Kentico.TextInput | — | — |
| 9 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 10 | MultipleChoice | Multiple choice | longtext | No | Kentico.MultipleChoice | — | — |
| 11 | RadioButtons | Radio buttons | text(200) | No | Kentico.RadioButtons | — | — |
| 12 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |
| 13 | TextBoxReload | Text Box With Reload | text(200) | No | BDO.FormComponent.TextBoxReload | — | — |
| 14 | Recaptcha | — | text(1) | No | Kentico.Recaptcha | — | — |

### RKGatedDownload — _Gated Download for insights_

- **Table:** `Form_GWT_TST_RKGatedDownload`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | RKGatedDownloadID | RKGatedDownloadID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | First name* | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextInput_1 | Last name* | text(500) | No | Kentico.TextInput | — | — |
| 6 | TextInput_2 | Company* | text(500) | No | Kentico.TextInput | — | — |
| 7 | EmailInput | Email | text(500) | No | Kentico.EmailInput | — | — |

### RKNewForm — _RK New Form_

- **Table:** `Form_GWT_TST_RKNewForm`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | RKNewFormID | RKNewFormID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | First Name | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | Last Name | text(500) | No | Kentico.TextInput | — | — |
| 6 | MultipleChoice | — | longtext | No | Kentico.MultipleChoice | — | — |
| 7 | BDOConsentAgreement | BDO Consent Agreement | text(100) | No | BDO.FormComponent.BDOConsentAgreement | — | — |
| 8 | Recaptcha | reCAPTCHA | text(1) | No | Kentico.Recaptcha | — | — |
| 9 | RadioButtons | Radio buttons | text(200) | No | Kentico.RadioButtons | — | — |
| 10 | CheckBox | Checkbox | boolean | No | Kentico.CheckBox | — | — |

### TestContactUs — _Test ContactUs_

- **Table:** `Form_GWT_TST_TestContactUs`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | TestContactUsID | TestContactUsID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | TextInput | First Name | text(500) | No | Kentico.TextInput | — | — |
| 5 | TextInput_1 | URL | text(500) | No | Kentico.TextInput | — | — |

### TestFormLT — _Test Form LT_

- **Table:** `Form_GWT_TST_TestFormLT`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | TestFormLTID | TestFormLTID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |

### Upload — _Upload_

- **Table:** `Form_GWT_TST_Upload`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | UploadID | UploadID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FileUploader | File uploader | bizformfile | No | Kentico.FileUploader | — | — |

### URL_R_dir_ction_T_st — _URL-Rædiræction-Tæst_

- **Table:** `Form_GWT_TST_URL_R_dir_ction_T_st`
- **Site:** GWT TST
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | URL_R_dir_ction_T_stID | URL_R_dir_ction_T_stID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### Carerix — _Carerix_

- **Table:** `Form_Integrations_Carerix`
- **Site:** Integrations
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | CarerixID | CarerixID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### CarerixInterimKandidaat — _CarerixInterimKandidaat_

- **Table:** `Form_Integrations_CarerixInterimKandidaat`
- **Site:** Integrations
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | CarerixInterimKandidaatID | CarerixInterimKandidaatID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |

### BDOEventTemplate_DoNotModify — _* BDO Event Template (Do Not Modify)_

- **Table:** `Form_BDOWOW_BDOEventTemplate_DoNotModify_1`
- **Site:** www.bdowow.com
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDOEventTemplate_DoNotModifyID | BDOEventTemplate_DoNotModifyID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

### BDOEventTemplate_DoNotModify — _* BDO Event Template (Do Not Modify)_

- **Table:** `Form_BDOWOW_BDOEventTemplate_DoNotModify`
- **Site:** www.bdowow.global
- **Submit action:** —
- **Notification email:** —
- **Confirmation email:** —
- **Log activity:** Yes

| # | Field | Caption | Type | Required | Admin Component | Live Site Component | Validation |
| --- | ----- | ------- | ---- | -------- | --------------- | ------------------- | ---------- |
| 1 | BDOEventTemplate_DoNotModifyID | BDOEventTemplate_DoNotModifyID | integer | No | — | — | — |
| 2 | FormInserted | Form inserted | datetime | No | — | — | — |
| 3 | FormUpdated | Form updated | datetime | No | — | — | — |
| 4 | FirstName | {$BDO.LiveSite.Form.FirstName$} | text(500) | No | Kentico.TextInput | — | — |
| 5 | LastName | {$BDO.LiveSite.Form.LastName$} | text(500) | No | Kentico.TextInput | — | — |
| 6 | Email | {$BDO.LiveSite.Form.Email$} | text(500) | No | Kentico.TextInput | — | — |
| 7 | PhoneNumber | {$BDO.LiveSite.Form.PhoneNumber$} | text(500) | No | Kentico.TextInput | — | — |
| 8 | Company | {$BDO.LiveSite.Form.Company$} | text(500) | No | Kentico.TextInput | — | — |
| 9 | JobTitle | {$BDO.LiveSite.Form.JobTitle$} | text(500) | No | Kentico.TextInput | — | — |
| 10 | SecurityCode | Security Code | text(1) | No | BDO.FormComponent.SecurityCode | — | — |

