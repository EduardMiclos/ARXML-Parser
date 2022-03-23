# ARXML Parser

This is an **ARXML Parsing tool** I developed for **Continental**.
It's easy to use and very flexible. All you have to do is:

### 1. Create an **Excel** file.

   It should contain one table with 3 columns:

• **Column 1 ('FILE')**. Here, we specify the full path to the file that needs to be changed.<br>
*Pro tip: if multiple changes need to be applied to the same file, it is enough to only specify the path once and leave the rest of the Column 1 rows empty until you reach the next file (if it exists) or until the end* (see the example below).

• **Column 2 ('FROM')**. Here we specify the string component that is being replaced.

• **Column 3 ('TO')**. Here we specify the string component used to replace all the occurrences of the first one.

**Respecting the naming convention is mandatory**.

For example:

![image](https://user-images.githubusercontent.com/59684906/159684734-bfb8fd46-9a39-4e0d-a326-5b955a21b8ca.png)

### 2. Open the program.
This is how it looks like (for now):

![image](https://user-images.githubusercontent.com/59684906/159685547-5857ead0-8fac-48c9-9dd2-b5af775fdc81.png)

Here, you can:

  • select your Excel file (**SELECT EXCEL** button).<br>
  • read information regarding how the Excel file should look like (**EXCEL Info** button).<br>
  • change the REGEX expression used to search for patterns inside your files (**Change REGEX** button).<br>
  • choose whether to make destructive (the original file is overwritten) or non-destructive changes (the changes are applied to a copy of the original file, with the name ORIGINAL_FILE_NAME + "_parsed").<br>
  • choose whether the program shall use less memory (slower) or more memory (faster).<br>
  • parse your file.
  

### 3. Check the results inside the console.
  
