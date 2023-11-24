var dax = 
 
@"ADDCOLUMNS(
   CALENDAR( MIN ( superstore_final_dataset[Ship_Date] ), MAX ( superstore_final_dataset[Ship_Date] )),
   ""Month No"" , MONTH([Date]),
   ""Month Name"" , LEFT ( FORMAT( [Date] , ""Mmmm"" ), 3 ),
   ""Month Longname"" , FORMAT( [Date] , ""Mmmm"" ),
   ""Year"" , YEAR([Date]),
   ""Month Year No"" , (YEAR([Date]) * 100) + MONTH ([Date]),
   ""Month Year"" , FORMAT( [Date] , ""Mmm yyyy""),
   ""Quarter"" , QUARTER([Date]),
   ""Year Qtr"" , FORMAT( [Date] , ""YYYY \QQ""),
   ""Week Day"" , WEEKDAY([Date],2),
   ""Week"" , FORMAT( [Date] , ""Dddd"" )
 
)";
 
Model.AddCalculatedTable("Calendar", dax);