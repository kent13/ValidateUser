### How to retrieve google sheet as CVS

https://stackoverflow.com/questions/33713084/download-link-for-google-spreadsheets-csv-export-with-multiple-sheets

Every document in Google Sheets supports the "Chart Tools datasource protocol", which is explained (in a rather haphazard way) in these articles:

1. "Creating a Chart from a Separate Spreadsheet" https://developers.google.com/chart/interactive/docs/spreadsheets

2. "Query Language Reference" https://developers.google.com/chart/interactive/docs/querylanguage

3. "Implementing the Chart Tools Datasource Protocol" https://developers.google.com/chart/interactive/docs/dev/implementing_data_source


To download a specific sheet as a CSV file, replace {key} with the document's ID and {sheet_name} with the name of the sheet to export:

https://docs.google.com/spreadsheets/d/{key}/gviz/tq?tqx=out:csv&sheet={sheet_name}

The datasource protocol is quite flexible. Various other options include:

Response Format: Options include tqx=out:csv (CSV format), tqx=out:html (HTML table), and tqx=out:json (JSON data).

Export part of a sheet: Supply the range={range} option, where the range can be any valid range specifier, e.g. A1:C99 or B2:F.

Execute a SQL query: Supply the tq={query} option, such as tq=SELECT a, b, (d+e)*2 WHERE c < 100 AND x = 'yes'.

Export textual data: Supply the headers=0 option in case your fields contain textual data, otherwise they might be cut out during export.

### What worked for me
1. Save the sheet with the data you want to retrieve
1. Share the document to anyone to view
1. Grab the the shared link
1. Replace "edit?usp=drive_link" with "export?format=csv"

If you paste the edited URL into a browser you will be prompted to save the file.

"https://docs.google.com/spreadsheets/d/14oq2ZT7BlfddCh-p5IzA4RdwNMM6d344U6ELSyjCU7c/edit?usp=drive_link"

"https://docs.google.com/spreadsheets/d/14oq2ZT7BlfddCh-p5IzA4RdwNMM6d344U6ELSyjCU7c/export?format=csv";