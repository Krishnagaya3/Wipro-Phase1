import React , {useState, useEffect, Component} from "react";

// example of useEffect which is used to monitor the side effects like data fetching

// mounting -- >  that a component is added to the DOM for the first time . It happends when
// 1. the component is appeared first time  2.  React renders that component for the first time

// class component mounting  -->  componentDidMount() to check wether the component is mounted or not

// class MyComponent extends Component{


//     componentDidMount()
//     {

//         console.log("component mounted");

//     }
//     render()
//     {

//         return <h1> Rendered  and Mounted</h1>
//     }
// }
// export default MyComponent;

const MyComponent = () => {

    //first case  -- Mounting when the component is added to the DOM (first renders)
    useEffect(
       
        () => {
        console.log("Component Mounted called only once");

      return () => {
        console.log("component Unmounted ");
    
    };
 }, []

); // Empty array means it's not dependent on any thing and it runs only once
     
   
   // updating  -- when the component re-enders due to state or prop change
  // useEffect(() => {console.log("Component Mounted and also updated due to state or prop change ");});

  // Unmounting --  when the component is removed from the DOM , removing stop timer  , event listeners
    //return () =>{ console.log("Component unmounted .. ");}; ,[...]);
   
    return <h2> Rendered and Mounted </h2>
};



const App = () =>{

const[show , setShow] = useState(true);

return(

    <div>
    <button onClick={() => setShow(!show)}>{show ? "Hide the component" : "show the component"}</button>
    
    {show && <MyComponent />}
    </div>


);


};
export default App
