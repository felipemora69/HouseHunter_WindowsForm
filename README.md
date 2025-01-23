# HouseHunter_WindowsForm
House Hunter Rapid Application Form (Windows Forms)

The House Hunter Rapid Application Form is a Windows Forms application designed to help users search for and filter houses based on their preferences. The app integrates with a backend database, allowing users to dynamically query and filter available houses based on criteria such as location, price, and postal code. The user interface provides an easy-to-navigate form where users can enter search parameters and view matching results.

The project includes both a front-end (Windows Forms UI) and back-end (database interaction using SQL Server). It allows users to:

View a list of houses from the database.
Filter properties based on search criteria.
Display detailed property information, including address, postal code, and list price.

Features
Dynamic Property Search: Fetches data from a backend SQL database.
Filters: Users can filter properties by ID, address, postal code, or list price.
User-Friendly UI: An intuitive form layout that allows for easy searching and viewing of properties.
Real-Time Data Display: Updates the list of houses based on user search criteria, ensuring real-time interaction with the data.

How It Works
Load Data: On clicking the "Get Data" button, the app retrieves house information from the SQL Server database and displays it in the list.
Search and Filter: Users can filter properties based on various criteria (ID, Address, Postal Code, List Price). The filter updates the displayed list of houses in real-time.
Display Results: Matching properties are shown in a ListView control, where users can easily view the property details.

