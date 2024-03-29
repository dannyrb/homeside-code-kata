# homeside-code-kata


## Overview

Goal of this exercise is to build a web portal that allows all departments to upload (csv documents), download(csv documents) and submit tasks that automate various internal manual efforts. This will become the backbone of all department automations and must be able to quantify the work automated.

## To Do:
- [x] Establish basic architecture laid out in step 1 of the requirements section.
- [x] Create a test page containing a jQuery datatable
- [x] Remove views that are not needed for our SPA portal
- [x] Remove bootstrap styling, if possible
- [x] Move script and style management to bower
- [x] Begin building out "gohomeside.com theme" in SASS by matching color palletes
- [x] Material design: start with buttons, slide pane, grid, main layout
- [x] Create "dummy" buttons that open slide pane to finish steps 2 and 3
- [x] Flush out data model using EF
- [x] Seed data for table using Faker library
- [x] Update jQuery datatable to use correct columns
- [x] Implement automapper to assist with domain -> dto -> vm mappings
- [x] Wire up jQuery datatable to pull up-to-date data from an API endpoint
- [x] Create AJAX endpoint for file upload
- [x] Setup basic submission form
- [x] Pass data AND file, create basic new entry, refresh table's data
- [x] Pull "file" into a seperate linked table
- [x] Move step 3's buttons to the main navigation bar [Not ideal for "actions", but will suffice for now]
- [x] Wire buttons up to load different content in modal
- [x] Select2 for user form select
- [x] Clean form
- [x] Add "toast" notifications for SubmitTask method on front-end
- [x] Add clientside validation for basic form
- [x] Check to see how "errors" are returned with JsonNetResult
- [x] Begin to create WindowsService Project
- [x] Immediately mark task as "processing" when pulled from queue
- [x] Mock "processing time" for each task in queue
- [x] Clean up windows service
- [x] Remove Id Column from data-table
- [x] Store filepath and url? URL can probably be a way to retrieve via a get request using fileID
- [x] Better form button styling
- [x] Increase "toast" duration
- [x] Create docs for "windows service install"
- [x] Install windows service locally (start / stop / test)
- [ ] Generate bullet points for posed questions in problem's prompt
- [x] Begin working on bonus items

#### Housecleaning: Bonus
- [x] SubmitTaskDto -> In AfterMap... Use EF's "Attach" method in place of "ResolveUserById" to prevent insert of existing user on save
  - http://stackoverflow.com/questions/13003345/how-can-i-prevent-ef-from-inserting-an-object-that-already-exists-in-the-db-when
- [ ] Enhance theme further (datatable, headings, hover effects, etc.)
- [ ] Implement a responsive datatable
- [ ] Task type(think about using this in #7 to create a structure that will us to plug in different actions or automations for each type)
	- Think about pulling this out into a seperate table
	- Investigate ways to use this field in step #7 as suggested...
	- Linked table where each task has associated actions (front-end fields required), and PowerShell or Python scripts?
- [ ] Data annotations on DTO, and check for server side valid
  - Method to display server side validation errors
- [ ] Pull domain enums into their own tables (CRUD management later on?)
- [x] Add quick filters for datatable (status) && REFRESH *****
- [ ] Add a more obvious differentiatior for status (color / shape / icon)
- [ ] Enhance seed data (timestamps and states match up)
- [ ] Explore datatable configuration properties
- [ ] Drag & Drop upload
- [ ] Shift REST API endpoints to Web API controllers
- [ ] Flush out toolkit to include all elements and molecules used
- [ ] Create front-end "seed data" buttons for traffic simulation
- [ ] Polish notification removal to "fade out"
  - [ ] Polish further with dismiss and dismiss all buttons




 
## Requirements

1. ~~MVC .net 4.6, c#, entity framework, sql server 2014 express, git (source control)~~
2. ~~Build a portal (no authentication) that uses our (gohomeside.com) theme.~~
3. ~~User interface should have buttons / options for “Pay MIP”, ”Post Transactions”, “Create warehouse line file”~~
4. ~~Action for each option will allow the user to upload a csv file and submit the task~~
5. ~~Each submission should create a new task in the database with the following (create a normalized data scheme)~~
  * ~~Task type (think about using this in #7 to create a structure that will us to plug in different actions or automations for each type)~~
  * ~~Task name~~
  * ~~Task description~~
  * ~~Start datetime~~
  * ~~End datetime~~
  * ~~User who submitted the task~~
  * ~~Status (queued, processing, finished, error)~~
  * ~~File path / url to file uploaded~~
6. ~~create a status page that utilizes jquery datatables to show each task in queue and the status. Order by date created. You should have 1 datatable. It must convey to the user which tasks are queued, processing, failed and successful.~~
7. ~~Lastly, create a c# windows service that queries the database you created, for all tasks in queued status.~~
8. ~~For now, don’t worry about the actual actions / code to implement each. Just set the end datetime and go onto the next queued item ( later, if hired, we will work on the automation / action code)~~
  * Think about a scalable way to implement the actions so that over the next few years will have reusable actions that can be plugged into / reused. You don’t have to necessarily create all of it now but be able to speak to your plan on how we can implement this idea.
9. ~~Lastly the windows service must process tasks in parallel (concurrently using multi-threading) and update the database immediately when a task is pulled off the queue (setting status to processing etc).~~

 
## The Review
* Must be able to demo this application to Dan and I next week.
* Must be able to review code and speak to why decisions were made.
* Must be able to suggest other designs or technologies that would work better
* Suggestion on how to log into various websites to automate clicking  and submitting. Frameworks?
* Give us a brief overview of how you would track analytics given one action / task saves x amount of time.
* All must work on your laptop. Let’s not worry about installing / deploying the solution.



### WinService Install

1. Build WindowsService Project as Release
2. Move `bin/release` to a new location on C drive
3. Locate InstallUtil (C:\Windows\Microsoft.NET\Framework\vXXXXX\InstallUtil)
4. Open command prompt as admin
5. Navigate to WindowsService files location
6. Run following command:

`C:\Windows\Microsoft.NET\Framework\vXXXXX\InstallUtil /i NameOfMainFile.exe`

`/u` for uninstallse

7. Enter DOMAIN/usr (xx/brownd), and password