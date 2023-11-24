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

## Economic Data Project
You want to understand the impact of economic data like GDP, inflation rate or business climate index on your business? <br>
Analysing your own internal business numbers, like “Turnover” for different countries, is not too difficult. It requires a Datawarehouse & PowerBI and a Data Analyst. But knowing if the changes in these “Turnover” numbers correlate to economic data, like GDP, inflation rate, population size and finally drawing meaningful conclusions is a bit more difficult. If you don’t have Data Scientists or Mathematicians in your company it is a challenge. <br>
<br>
Why is it extremely helpful to know these relationships between your “internal data” (e.g. Turnover) and “external data” (e.g. economic data)? Because it is useful for a better plannability of ordered quantities of your products, for a better estimation of financial reserves and a more efficient stock management. <br>
<br>
But how to approach this question? <br>
If you are not familiar with correlation, variance, stochastic processes, simulation based mathematical models, then I recommend to simply start with a small PowerBI report like mine.   <br>

My PowerBI report contains: <br>
➡️Integrating raw data from different external data sources (e.g. Worldbank, Ifo-Institute,…). Data cleaning, pivotization (where needed) and merging the different data sources in order to achieve one (key,value)-fact-table.  <br>
➡️Extracting dimensions out of the raw data, like „country“- and „series“-dimension for being used in a star-schema model in the data model. <br>
➡️Defining a generic calendar table with DAX code. Define (1:n)-relationships to the fact-tables, where you aligned the different date-formats. Implementing DAX formulas for minimum and maximum, changes and averages.  <br>
➡️Creating highly interactive and easy understandable report pages which show YoY, MoM and continues data series. Using different visuals, buttons & bookmarks. <br>
 <br>
Datasources: <br>
Worldkbank: https://databank.worldbank.org/home.aspx, Series: GDP (currenct US$), Consumer price index (2010=100), Inflation, consumer prices (annual %), Format: Excel (CSV and Text also available), File: P_Data_Extract_From_World_Development_Indicators.xlsx <br>
Ifo-Insitute: https://www.ifo.de/ifo-zeitreihen, Series: Geschäftklimaindex (business climate index), Format: Excel, File: gsk-d-202310.xlsx  <br>
WSJ-Markets: https://www.wsj.com/market-data/quotes/index/DX/DAX/historical-prices, Series: DAX-Index, Format: CSV, File: HistoricalPrices.csv  <br>
Internal Datasources: the orders of customers. A fact-table of orders (Fact_Orders.xlsx) and a client dimension (Clients.xlsx) with random numbers to illustrate the approach.  <br>
<br> 
I published my PowerBI report on novyPro, which is a nice platform for data analysts. You can open and work with my PowerBI report on the novyPro page without installing anything. If you want to download the source and coding of my work, then use the GitHub page. <br>
novyPro: https://www.novypro.com/project/economic-report <br>
 <br>
 

