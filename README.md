# PowerBI example reports <br>using PowerQuery, DAX and Tabular Editor

This repository contains come PowerBI example reports using PowerQuery, DAX and Tabular Editor. You can open my PowerBI report on the novyPro page without installing anything. <br>
[https://www.novypro.com/profile_projects/andreastraut](https://www.novypro.com/profile_about/andreastraut)

## "Bicycle Count" report:
This small and highly interactive PowerBI example shows the count of bicycles passing 6 distinct places in Munich and the weather (rain, min. and max. temperature) on each day.

Techniques implemented: <br>
➡️reading 12 daily csv files and 12 more deailled csv files and joining the csv files into two datasets with PowerQuery<br>
➡️creating a flexible, non-static "places-Dimension" table and a calendar with hierarchies<br>
➡️defining relationships between the two datasets and the places-dimension-table and the calendar in Tabular Editor<br>
➡️defining DAX measures: total, average, min, max<br>
➡️creating line and barplot and filters on places and calendar in PowerBI Desktop<br>

Datasource: https://opendata.muenchen.de/dataset/daten-der-raddauerzaehlstellen-muenchen-2022 (OpenData)<br>

I published my PowerBI report via novyPro, which is a nice platform for data analysts and where you can immediately work with the report (without installing anything): 
https://www.novypro.com/project/bicycle-count

See also my LinkedIn post:<br>
https://www.linkedin.com/posts/activity-7110331190351384577-Fvod?utm_source=share&utm_medium=member_desktop

## "Superstore Sales" report in PowerBI

This is a report for analyzing the sales data of a supermarket. The report contains three pages: Report page "Overview" compares the regions/states and gives indications about the development in the different states/cites and categories (e.g. Technology), subcategories and segments (Consumer, Corporate, Home).  Reporting page "Time Analysis" reveals more information on the development and contains also trends (absolute and relative) compared to the previous year. The third reporting page "Customer Analysis" compares all costumers.

Techniques implemented:<br>
➡️Creating a customized calender with a CSX Script in Tabular Editor (which uses min and max of the Ship-Date of the dataset)<br>
➡️Defining measures using DAX (abs./rel. trends and totals) and hierarchies (e.g. for Region/State/City) and calculated columns (Customer&ID). <br>
➡️Using different kinds of interactive visuals (bar, line, maps, treemap) to analyze the data. Please click on the visuals and see how the other reveal more information about your selected item. <br>
➡️Contains "Color Coding" for trends and stars for customers.<br>

Datasource: https://www.kaggle.com/datasets/bhanupratapbiswas/superstore-sales (OpenData Commons)

See also my LinkedIn post:<br>
https://www.linkedin.com/posts/activity-7110992649116950530-LvqS?utm_source=share&utm_medium=member_desktop

## "Onyx Data Challenge": Youtube report in PowerBI

This is my participation for the "Onyx Dataset Challenge" as of November 2023. My PowerBI report contains: 
➡️Data cleaning in PowerQuery. Scaling of measures (like "Population" in millions). Creating "Created Data" column. <br>
➡️Splitting of raw dataset into a country dimension and a fact dataset. <br>
➡️Building a very simple datamodel with country dimension and fact dataset.<br>
➡️Creating different DAX measures (max, min, average, sum, ...). <br>
➡️Implementing a customer friendly possibility to scale the measures (like highest earning) in Thousand/K or Millions/M by using DAX calculation group. <br>
➡️Building highly interactive tables for analyzing country and youtubers using maps, cards, filters creation time, categories and channel types.<br>

The model has 24 MB, 5 Tables, 63 columns. Calculation time for the whole report in total is about 180ms for formula engine. The remaining time is mostly rendering and waiting for other visuals to complete.

👉 Please click somewhere in the tables and see how the others interact!<br>
👉 Use the "sort by" possibility to navigate through the data.

I published my PowerBI report via novyPro, which is a nice platform for data analysts and where you can immediately work with the report (without installing anything): https://www.novypro.com/project/onyx-dataset-challenge---youtuber-

Datasource: https://onyxdata.co.uk/data-dna-dataset-challenge/

See also my LinkedIn post:<br>
https://www.linkedin.com/posts/activity-7126906747499212800-B_AE?utm_source=share&utm_medium=member_desktop


