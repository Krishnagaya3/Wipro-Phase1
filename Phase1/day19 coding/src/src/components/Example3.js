import React ,{useEffect,useState} from "react";

const StockPriceTracker = () => {

  const[stockPrice , setStockPrice] = useState(100); // initial stock Price
   const[count , setCount] = useState(0);
       //first case  -- Mounting when the component is added to the DOM (first renders)
       useEffect(
          
           () =>    {
                    //mounting
                    console.log("Component Mounted called only once", count);
   
                     const interval = ( () => {
                      const newPrice = (Math.random() * (105 - 95) + 95).toFixed(2);
                      console.log(`Stock price Update : ${newPrice}`);
                      setStockPrice(newPrice)  // triggerin a re-ender

                     } )

                     // unmounting
                     return() => {
                        clearInterval(interval);
                        console.log("Component unmounted" )
                     }

                     }, [count]  // use some dependency
   
                 );


                 return (

                    <div>
                        <h2> Stock Price : {stockPrice} </h2>
                        <button onClick= {() => setCount(count+1) }>Show </button>
                    </div>
                 );

};

export default StockPriceTracker;