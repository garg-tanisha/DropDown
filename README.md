# DropDown

Tasks : 
1) Use MSTest to write tests 
2) Google search - fill in the query ("GeeksForGeeks") and enter (keyboard)
3) Select the website link from there
4) Select from dropdown - from a list, extract the required element and click it. Follow same, for other dropdowns
5) Use Assert to check if the page title matches with the required page title

Workflow:

a. Fields
1) Initilize instance of ChromeDriver class

b. TestInitialize 
1) Go to the Url "http://google.com"
2) Maximize browser
3) Set implicit time wait (which stays for entire session)

c. TestMethod
1) Finds the element with the Name "q" and enters "GeeksForGeeks" there and press Enter (keyboard)
2) Finds element with the ClassName "r" and click it (Clicking 'GeeksForGeeks' website link)
3) Finds element with Id "menu-item-351946" and click it (Clicking Tutorials)
4) Finds element with Id "menu-item-351977" and click it (Clicking Sub Parts of it)       
5) Finds element with Id "menu-item-362995" and click it (Clicking Super Sub Part of it)
6) Use Assert to check if the page title matches with the required page title ("Stack Data Structure - GeeksforGeeks")
7) Exception handling is also used

d. TestCleanup : 
1) Closes the browser
2) Quits
