# Worthy-care
Worthy-care works for communities, have a lot of data to manage Charity management database system-GGRF.

Association works with community have a lot of data to manage, this system enables end user to easily 
input or enter data such as charity Event, Subscribers, Sponsors, Donations into a sql database.
This is to serve the users in a friendly way to input the data and extract it fairly easy and straight forward and aid to support the association 
to make a progress and to process the data quickly with less cost.

Background:
-----------
Charity management database system-GGRF.
Charity works with community have a lot of data to manage, this software enable one to easily 
input or enter data such as charity Event, Subscribers, Sponsors, Donations into a sql database.
This management system is a front end GUI, programmed in C Sharp part of Visual Studio platform.

Why is created:
--------------
I developed this system to learn and updating my knowledge in CSharp as part of process and make it real system to be implemented 
for a company but instead of MS SQL, it will be SQLite, as an external database storage.   

Introduction:
-------------
Worthy-Care project is an accurate data displaying; for the users to take part to input data and 
display it.
There are a number of forms for data input & output.

At later stage the SQL database will get replaced by SQLite database that holds the data inserted 
and retrieved.
There are progessing perspectives at the moment applying ASP.NET to get end users interact with the system 
using the system web site, the ASP.NET with CSS including Bootstrap will let end users input 
the data from web site and also review it from external platform using internet facilities.
API is another mechanisn that will be introduce to get Paypal Worthy-Care account to receive the payment
made by the subscribers and sponsors, whether anonymously or with their details typed in.

The project uses a database that composes of six tables and are highly normilised and avoid redundancy of data and
to hold data in the MSSQL database at the back and CSharp code to communicate(i.e. input and output) with it.
The tables are: 
	Event: is the main entity that the system spines around it, it holds data of 
		the event and the entities that surround it.
	Subscriber: it is a spiral entity that subscribers could be all  along with or wihout an event.
	            Event entity holds the data about the subscribers and could be displyed
	Sponsor: its an entity that holds data about the sponsors that sponsor the events, they
		 could be either associations, companies or individuals.
	Donation: its role seems obvious from its name, it holds the data about and the type
		  donation.
These are the main entities that the system, is based on and then again there are also the composite
entities that break the man:many relationship and hold the data from both entities and constraint 
applied in an attempt to avoid data redundancy.

Composite entities are:
Subscriber_Event: holds the the key of the Event and which subscriber(key) attended the event.
Sponsor_Event: holds the key of the Event and which sponsor(key) attended or funded it.
	
 Sponsor_Event: similar description applies with this entity as it holds the key of both entities
	Event and Sponsor.

C Sharp language is to get flowing communication between the Database and the data entry forms in the
system.

In the initial class public partial class Dashboard : Form
 I added included files library to be able to use the classes needed: 
	1) using System.Windows.Forms
	2) using System.Data.SqlClient 
from the .NET library to interact with the database that I developed and saved in SQL Sever.
using (SqlConnection connection = new SqlConnection("Server=localhost;Initial Catalog=Gr_management;Integrated Security=True;"))
When the Dashboard form loads, the connection string runs and creates connection with the database that's in the server.
This is purely for learning purposes, noone is allowed to copy for commercial or trading purposes. 

Worthy-Care: v1.0.0
