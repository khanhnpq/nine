API TEST:

API endpoint example:
https://localhost:44321/api/people/get/summary

To add 1 age to all persons in people stub, run this API endpoint:
https://localhost:44321/api/people/get/add1age
And then you can run the get/summary endpoint above to test if the age has been incremented

Other endpoints, this is useful for testing if caching works.

List all people:
https://localhost:44321/api/people/

List all people, by race:
https://localhost:44321/api/people/get/angle
https://localhost:44321/api/people/get/saxon
https://localhost:44321/api/people/get/jute

RAZOR VIEW PAGE Test:

Run project by click on IISExpress
Default page will load up
https://localhost:44321/Home/

Select value from drop down list to get the list of even-aged-people filtered by race

NOTE: Known bug: reset drop down list will cause page error, it should load back to the default /Home page
