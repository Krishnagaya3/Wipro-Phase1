import React , {useState ,useCallback} from "react";


//we have created two components 1. Child and another one is Parent 

// receive a function handleclick as a prop and renders one button
const Child  =React.memo(({handleClick}) => {


    console.log("Child  rendered ");

    return <button onClick={handleClick}>child Button</button>
});

//renders a counter and also a child component
const Parent = () =>{

const [count , setCount] = useState(0);
console.log("Parent is getting reendered");

// is used to memoize the function memoHandleClick to prevent unnecessary re-enders-- on every reender this is not recreated 
const memoHandleClick =  useCallback(() => {
  console.log("Child Button Clicked which is not re-endered every time ");
   // setCount((prev) => prev + 1);
},[]);  // memoHandleClick will never changes once created 

return (
        <div>
            <h2> Count : {count}</h2>    
            <p> updates count , which means triggering the parent which will re-ender on a button click</p>
            <button onClick={() => setCount(count+1)}>Parent Button</button>

            <p> here we are passing the memoHandleClick to this child component, since here we
                are using the memoied child does not re-ender
            </p>
            <Child handleClick ={memoHandleClick} />
        </div>  
)

};
export default Parent;