import React, { useState, useEffect } from 'react';
import { ReactDOM } from 'react';
import Menu from './nav';
import axios from "axios";

function VehicleList() {

    // State to store the fetched data
    const [data, setData] = useState([]);

    // Function to fetch data using Axios
    const fetchData = async () => {
        try {
            const response = await axios.get("http://localhost:3000/cars");
            setData(response.data);
        } catch (error) {
            console.error("Error fetching data:", error);
        }
    };

    // Call fetchData on component mount
    useEffect(() => {
        fetchData();
    }, []);

    //create the about content using data-testid="about-content"
    return (
        <div>
            <div data-testid="about-content">
                <Menu></Menu>
                <div className='row'>
                    <div className='col-12'>
                        <div className="card-group">
                            {data.map((temp) => (
                                <div className="card">
                                    <img src="{temp.image}" className="card-img-top" alt="..." />
                                    <div className="card-body">
                                        <h5 className="card-title">{temp.name}</h5>
                                        <p className="card-text">{temp.description}</p>
                                        <p className="card-text">
                                            Seats : {temp.seats}
                                            <br></br>
                                            Mileage : {temp.mileage}
                                            <br></br>
                                            Fuel : {temp.fuelType}
                                            <br></br>
                                            Gear : {temp.gearType}
                                            <br></br>
                                        </p>
                                    </div>
                                </div>
                            ))}
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default VehicleList;