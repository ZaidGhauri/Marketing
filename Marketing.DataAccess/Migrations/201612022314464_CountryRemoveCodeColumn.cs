namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryRemoveCodeColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Countries", "Code");

            Sql("insert into Countries values ('United States','US', 'USA',840,1,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Canada','CA', 'CAN',124,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Argentina','AR', 'ARG',32,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Armenia','AM', 'ARM',51,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Aruba','AW', 'ABW',533,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Australia','AU', 'AUS',36,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Austria','AT', 'AUT',40,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Azerbaijan','AZ', 'AZE',31,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bahamas','BS', 'BHS',44,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bangladesh','BD', 'BGD',50,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Belarus','BY', 'BLR',112,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Belgium','BE', 'BEL',56,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Belize','BZ', 'BLZ',84,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bermuda','BM', 'BMU',60,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bolivia','BO', 'BOL',68,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bosnia and Herzegowina','BA', 'BIH',70,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Brazil','BR', 'BRA',76,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bulgaria','BG', 'BGR',100,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cayman Islands','KY', 'CYM',136,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Chile','CL', 'CHL',152,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('China','CN', 'CHN',156,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Colombia','CO', 'COL',170,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Costa Rica','CR', 'CRI',188,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Croatia','HR', 'HRV',191,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cuba','CU', 'CUB',192,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cyprus','CY', 'CYP',196,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Czech Republic','CZ', 'CZE',203,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Denmark','DK', 'DNK',208,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Dominican Republic','DO', 'DOM',214,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Ecuador','EC', 'ECU',218,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Egypt','EG', 'EGY',818,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Finland','FI', 'FIN',246,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('France','FR', 'FRA',250,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Georgia','GE', 'GEO',268,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Germany','DE', 'DEU',276,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Gibraltar','GI', 'GIB',292,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Greece','GR', 'GRC',300,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Guatemala','GT', 'GTM',320,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Hong Kong','HK', 'HKG',344,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Hungary','HU', 'HUN',348,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('India','IN', 'IND',356,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Indonesia','ID', 'IDN',360,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Ireland','IE', 'IRL',372,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Israel','IL', 'ISR',376,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Italy','IT', 'ITA',380,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Jamaica','JM', 'JAM',388,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Japan','JP', 'JPN',392,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Jordan','JO', 'JOR',400,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Kazakhstan','KZ', 'KAZ',398,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Korea, Democratic People''s Republic of','KP', 'PRK',408,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Kuwait','KW', 'KWT',414,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Malaysia','MY', 'MYS',458,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mexico','MX', 'MEX',484,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Netherlands','NL', 'NLD',528,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('New Zealand','NZ', 'NZL',554,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Norway','NO', 'NOR',578,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Pakistan','PK', 'PAK',586,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Paraguay','PY', 'PRY',600,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Peru','PE', 'PER',604,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Philippines','PH', 'PHL',608,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Poland','PL', 'POL',616,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Portugal','PT', 'PRT',620,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Puerto Rico','PR', 'PRI',630,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Qatar','QA', 'QAT',634,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Romania','RO', 'ROM',642,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Russia','RU', 'RUS',643,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Saudi Arabia','SA', 'SAU',682,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Singapore','SG', 'SGP',702,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Slovakia (Slovak Republic)','SK', 'SVK',703,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Slovenia','SI', 'SVN',705,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('South Africa','ZA', 'ZAF',710,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Spain','ES', 'ESP',724,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Sweden','SE', 'SWE',752,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Switzerland','CH', 'CHE',756,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Taiwan','TW', 'TWN',158,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Thailand','TH', 'THA',764,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Turkey','TR', 'TUR',792,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Ukraine','UA', 'UKR',804,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('United Arab Emirates','AE', 'ARE',784,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('United Kingdom','GB', 'GBR',826,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('United States minor outlying islands','UM', 'UMI',581,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Uruguay','UY', 'URY',858,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Uzbekistan','UZ', 'UZB',860,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Venezuela','VE', 'VEN',862,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Serbia','RS', 'SRB',688,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Afghanistan','AF', 'AFG',4,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Albania','AL', 'ALB',8,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Algeria','DZ', 'DZA',12,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('American Samoa','AS', 'ASM',16,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Andorra','AD', 'AND',20,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Angola','AO', 'AGO',24,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Anguilla','AI', 'AIA',660,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Antarctica','AQ', 'ATA',10,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Antigua and Barbuda','AG', 'ATG',28,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bahrain','BH', 'BHR',48,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Barbados','BB', 'BRB',52,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Benin','BJ', 'BEN',204,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bhutan','BT', 'BTN',64,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Botswana','BW', 'BWA',72,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Bouvet Island','BV', 'BVT',74,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('British Indian Ocean Territory','IO', 'IOT',86,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Brunei Darussalam','BN', 'BRN',96,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Burkina Faso','BF', 'BFA',854,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Burundi','BI', 'BDI',108,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cambodia','KH', 'KHM',116,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cameroon','CM', 'CMR',120,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cape Verde','CV', 'CPV',132,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Central African Republic','CF', 'CAF',140,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Chad','TD', 'TCD',148,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Christmas Island','CX', 'CXR',162,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cocos (Keeling) Islands','CC', 'CCK',166,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Comoros','KM', 'COM',174,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Congo','CG', 'COG',178,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cook Islands','CK', 'COK',184,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Cote D''Ivoire','CI', 'CIV',384,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Djibouti','DJ', 'DJI',262,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Dominica','DM', 'DMA',212,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('El Salvador','SV', 'SLV',222,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Equatorial Guinea','GQ', 'GNQ',226,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Eritrea','ER', 'ERI',232,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Estonia','EE', 'EST',233,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Ethiopia','ET', 'ETH',231,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Falkland Islands (Malvinas)','FK', 'FLK',238,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Faroe Islands','FO', 'FRO',234,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Fiji','FJ', 'FJI',242,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('French Guiana','GF', 'GUF',254,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('French Polynesia','PF', 'PYF',258,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('French Southern Territories','TF', 'ATF',260,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Gabon','GA', 'GAB',266,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Gambia','GM', 'GMB',270,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Ghana','GH', 'GHA',288,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Greenland','GL', 'GRL',304,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Grenada','GD', 'GRD',308,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Guadeloupe','GP', 'GLP',312,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Guam','GU', 'GUM',316,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Guinea','GN', 'GIN',324,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Guinea-bissau','GW', 'GNB',624,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Guyana','GY', 'GUY',328,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Haiti','HT', 'HTI',332,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Heard and Mc Donald Islands','HM', 'HMD',334,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Honduras','HN', 'HND',340,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Iceland','IS', 'ISL',352,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Iran (Islamic Republic of)','IR', 'IRN',364,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Iraq','IQ', 'IRQ',368,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Kenya','KE', 'KEN',404,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Kiribati','KI', 'KIR',296,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Korea','KR', 'KOR',410,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Kyrgyzstan','KG', 'KGZ',417,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Lao People''s Democratic Republic','LA', 'LAO',418,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Latvia','LV', 'LVA',428,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Lebanon','LB', 'LBN',422,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Lesotho','LS', 'LSO',426,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Liberia','LR', 'LBR',430,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Libyan Arab Jamahiriya','LY', 'LBY',434,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Liechtenstein','LI', 'LIE',438,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Lithuania','LT', 'LTU',440,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Luxembourg','LU', 'LUX',442,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Macau','MO', 'MAC',446,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Macedonia','MK', 'MKD',807,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Madagascar','MG', 'MDG',450,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Malawi','MW', 'MWI',454,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Maldives','MV', 'MDV',462,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mali','ML', 'MLI',466,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Malta','MT', 'MLT',470,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Marshall Islands','MH', 'MHL',584,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Martinique','MQ', 'MTQ',474,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mauritania','MR', 'MRT',478,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mauritius','MU', 'MUS',480,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mayotte','YT', 'MYT',175,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Micronesia','FM', 'FSM',583,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Moldova','MD', 'MDA',498,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Monaco','MC', 'MCO',492,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mongolia','MN', 'MNG',496,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Montenegro','ME', 'MNE',499,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Montserrat','MS', 'MSR',500,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Morocco','MA', 'MAR',504,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Mozambique','MZ', 'MOZ',508,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Myanmar','MM', 'MMR',104,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Namibia','NA', 'NAM',516,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Nauru','NR', 'NRU',520,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Nepal','NP', 'NPL',524,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Netherlands Antilles','AN', 'ANT',530,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('New Caledonia','NC', 'NCL',540,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Nicaragua','NI', 'NIC',558,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Niger','NE', 'NER',562,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Nigeria','NG', 'NGA',566,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Niue','NU', 'NIU',570,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Norfolk Island','NF', 'NFK',574,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Northern Mariana Islands','MP', 'MNP',580,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Oman','OM', 'OMN',512,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Palau','PW', 'PLW',585,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Panama','PA', 'PAN',591,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Papua New Guinea','PG', 'PNG',598,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Pitcairn','PN', 'PCN',612,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Reunion','RE', 'REU',638,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Rwanda','RW', 'RWA',646,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Saint Kitts and Nevis','KN', 'KNA',659,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Saint Lucia','LC', 'LCA',662,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Saint Vincent and the Grenadines','VC', 'VCT',670,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Samoa','WS', 'WSM',882,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('San Marino','SM', 'SMR',674,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Sao Tome and Principe','ST', 'STP',678,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Senegal','SN', 'SEN',686,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Seychelles','SC', 'SYC',690,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Sierra Leone','SL', 'SLE',694,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Solomon Islands','SB', 'SLB',90,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Somalia','SO', 'SOM',706,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('South Georgia & South Sandwich Islands','GS', 'SGS',239,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Sri Lanka','LK', 'LKA',144,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('St. Helena','SH', 'SHN',654,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('St. Pierre and Miquelon','PM', 'SPM',666,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Sudan','SD', 'SDN',736,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Suriname','SR', 'SUR',740,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Svalbard and Jan Mayen Islands','SJ', 'SJM',744,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Swaziland','SZ', 'SWZ',748,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Syrian Arab Republic','SY', 'SYR',760,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Tajikistan','TJ', 'TJK',762,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Tanzania','TZ', 'TZA',834,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Togo','TG', 'TGO',768,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Tokelau','TK', 'TKL',772,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Tonga','TO', 'TON',776,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Trinidad and Tobago','TT', 'TTO',780,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Tunisia','TN', 'TUN',788,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Turkmenistan','TM', 'TKM',795,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Turks and Caicos Islands','TC', 'TCA',796,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Tuvalu','TV', 'TUV',798,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Uganda','UG', 'UGA',800,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Vanuatu','VU', 'VUT',548,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Vatican City State (Holy See)','VA', 'VAT',336,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Viet Nam','VN', 'VNM',704,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Virgin Islands (British)','VG', 'VGB',92,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Virgin Islands (U.S.)','VI', 'VIR',850,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Wallis and Futuna Islands','WF', 'WLF',876,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Western Sahara','EH', 'ESH',732,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Yemen','YE', 'YEM',887,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Zambia','ZM', 'ZMB',894,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')" +
               " insert into Countries values ('Zimbabwe','ZW', 'ZWE',716,100,1,0,1,GetDate(),'BackEnd',GetDate(),'BackEnd')");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Code", c => c.String());
        }
    }
}
