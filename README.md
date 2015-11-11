# MultilingualAspNetMvc

A multilingual asp.net mvc test.

Project consists of:
* 2 language resource files
* a Route to take the culture in the url {lang}-{country}/{controller}/{method} 
* a custom controller factory to pick up and set the current culture
* a basic model with validation error messages coming from the resource files

#Todo

* pull the default languages out of the route config
* Add a redirect so if you don't specify a lang/country for any route you get redirected to the same route with the language/country supplied in the request (Accept-Language) or the default lang/country, (/home/index -> /en-GB/home/index)
