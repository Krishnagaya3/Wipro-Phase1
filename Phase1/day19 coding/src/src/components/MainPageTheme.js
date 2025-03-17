import React , {useContext} from "react";

import ThemeContext from "./ThemeContext";

function HelloWorld ()
{

let theme = useContext(ThemeContext)
let data = useContext(ThemeContext)
let text = useContext(ThemeContext)
return (
   <>
  <div style= {{color:  theme.color , backgroundColor : theme.backgroundColor}}>

    REACT useContext Example ! 
  </div>

  <div>
    <p> UserDetails : {data.user.username}</p>
    <p> Whether that user is Admin : {data.isAdmin ? 'Yes' : 'No'}</p>
  </div>

  <div style = {{fontSize : text.textSize}}> Some more content added </div>
 
</>
);

}

export default HelloWorld;