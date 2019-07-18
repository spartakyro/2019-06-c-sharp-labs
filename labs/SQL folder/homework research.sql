-- SQL homework tests

--substring : substring (the string, start,length) (kieron,1,1) returns k
--the number in start matches the letter that number represents in the sting eg put 2 and the string will start at i in kieron
--length is how many letters of the string u wish to show eg 1 shows n, 2 shows ne,3 shows new ect

select FirstName, SUBSTRING(lastName,1,3) as Lastname from Employees order by FirstName asc

--CharIndex : finds where a string starts based on characters (spaces count at characters)
--the quick brown fox jumped over the moon
--charindex('brown',the words) from riddle, will return 11 since brown starts at the 11th character
select QuantityPerUnit,CHARINDEX('bags',QuantityPerUnit)from Products


--LEFT/RIGHT : choses the characters from a string based on the left or right
--must add the column from database and then add how many characters you wish to see from the string
--LEFT : LEFT(myname, 3) returns kie
--RIGHT : RIGHT(myname, 3) returns ron
SELECT right(ProductName, 5) from Products

--LTRIM/RTRIM : removes empty spaces from a string window RTRIM('kieron newman.      ') returns kieron newman with no paces on the end
-- LTRIM removes from the left side and RTRIM removes from the right.
SELECT RTRIM('Removes trailing spaces.   ');  

--