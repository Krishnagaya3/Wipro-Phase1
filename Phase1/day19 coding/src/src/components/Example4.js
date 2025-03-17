import React ,{useRef} from 'react';

const FocusInput  = () => {
 
    const inputRef = useRef(null); //  creating a null reference

     const FocusInput = ()=>{

        inputRef.current.focus(); // It will focus on input
     };

     return(

        <div>
            <input ref ={inputRef} type = "text"></input> <br />
            <input type = "text"></input>
            <button onClick={FocusInput}>Focus Input</button>
        </div>
     )

}
export default FocusInput;