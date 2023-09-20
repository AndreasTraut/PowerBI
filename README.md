# PowerBI example reports using PowerQuery, DAX and Tabular Editor

This reporistory shows some small PowerBI examples for showing some techniques in PowerQuery, DAX and PowerBI

## "Bicycle Count" report:
This small and highly interactive PowerBI example shows the count of bicycles passing 6 distinct places in Munich and the weather (rain, min. and max. temperature) on each day.

Techniques implemented: <br>
➡️reading 12 daily csv files and 12 more deailled csv files and joining the csv files into two datasets with PowerQuery<br>
➡️creating a flexible, non-static "places-Dimension" table and a calendar with hierarchies<br>
➡️defining relationships between the two datasets and the places-dimension-table and the calendar in Tabular Editor<br>
➡️defining DAX measures: total, average, min, max<br>
➡️creating line and barplot and filters on places and calendar in PowerBI Desktop<br>

Data from: https://opendata.muenchen.de/dataset/daten-der-raddauerzaehlstellen-muenchen-2022 (OpenData)<br>

I published my PowerBI report via novyPro, which is a nice platform for data analysts and where you can immediately work with the report (without installing anything): 
https://www.novypro.com/project/bicycle-count

See also my LinkedIn post:<br>
https://www.linkedin.com/posts/activity-7110331190351384577-Fvod?utm_source=share&utm_medium=member_desktop
