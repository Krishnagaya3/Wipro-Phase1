
$.post("https://jsonplaceholder.typicode.com/posts",
  {title:"this is a dummy title text",body:"this is a body text passing"},
  function(data,status){
  
  console.log(data,status);
  });

  $.get("https://jsonplaceholder.typicode.com/users",
    function(data,status){
    
    console.log(data,status);

    $('#output').load("demo.txt",function(response,statusTxt,xhr){
      console.log(response);
      console.log(statusTxt);
      console.log(xhr);
  });
  });