import React from "react";

const ThemeContext = React.createContext(

{
  color : 'Blue',
  backgroundColor : ' yellow',

  user : {username : 'Niti' , password : 'abc'},
  isAdmin:true,
  textSize : '80px'

}


)

export default ThemeContext;