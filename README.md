RESTful 
=======

Nina keeps REST easy, as it was planned to be. Supporting all verbs, through native


    Get("guest/{name}", (m,c) => Text("Hello, " + m["name"]));
    Post("/", (m,c) => View("views/blog", new Blog()));
    Put("/{id}/comments", (m,c) => Json(GetBlogWithComments()));
    Delete("/files/{id}", (m,c) => File(CONFIRMATION));
    

Friendly
========
Inspired by Sinatra, Nina has a compact and friendly DSL that you'll like from the start.   
    
    
    Post("/", (m,c)=>;
    {
      var url = Urls.Save(c.Request.Form["url"]);
      return Text(string.Format(@"<html><body>Your url: 
                <a href='{0}'>{0}</a></body></html>", c.Request.Url +url));
    });

Nina doesn't try to be everything. It does try to give you scenario-based programming
experience with performance to boot: ETagging, cache-control, JSON and XML serialization, growing number of view engines including <a href="http://code.google.com/p/nhaml/">NHaml</a>, <a href="http://ndjango.org/">NDjango</a>, <a href="http://sparkviewengine.com/">Spark</a> and more.

Nina lets you worry about your own code by giving you less decisions to make. In order to be more friendly, sometimes, there is (and should be) only one way to do it.
    

Performant
==========

Under the hood, Nina is a highly optimized microframework with
comprehensive features and a neat DSL.

To put it into numbers, here is the typical string rendering benchmark.
    
    
    Requests per second:    2385.19 [#/sec] (mean)<br/>
    Time per request:       0.544 [ms] (mean)
    
   
Get Started
===========
in progress.
    
    