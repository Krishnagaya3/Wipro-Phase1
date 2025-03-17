import react , {useState} from 'react';

// Example of Managing State in functional components
const Counter = () => {

    const[count , setCount] = useState(0); // initial value is set in a count variable
     console.log("count value is :" , count);

    return (
        <div>
            <h2> Initial Count Value is  : {count}</h2>
            <button onClick={() => setCount(count +1)}> Click to increment the count value </button>
            </div>


    );
};
export default Counter;