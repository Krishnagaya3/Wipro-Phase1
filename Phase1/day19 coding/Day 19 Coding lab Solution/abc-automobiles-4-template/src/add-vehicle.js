import React, { useState } from 'react';
import { ReactDOM } from 'react';
import Nav from './nav';
import { Formik, Field, Form } from "formik";
import axios from "axios";

function AddVehicle() {

    const [data, setData] = useState([]);

    //create the about content using data-testid="about-content"
    return (
        <div>
            <div data-testid="about-content">
                <div className='row'>
                    <div className='col-12 col-md-3'>
                        <Formik
                            initialValues={{ name: "", email: "" }}
                            onSubmit={async (values) => {
                                await new Promise((resolve) =>
                                    setTimeout(resolve, 500));
                                //alert(JSON.stringify(values, null, 2));
                                console.log(values);
                                //calling axios to store the data
                                
                                axios.post("http://localhost:3000/cars", values).then((response) => {
                                    console.log(response.status, response.data.token);
                                    setData("success");
                                });
                            }}
                        >
                            <Form>
                                <div className='form-group'>
                                    <label>Image</label>
                                    <Field data-testid="image" className="form-control" name="image" type="text" required />
                                </div>
                                <div className='form-group'>
                                    <label>Name</label>
                                    <Field placeholder="name" data-testid="name" className="form-control" name="name" type="text" required />
                                </div>
                                <div className='form-group'>
                                    <label>Price</label>
                                    <Field data-testid="price" className="form-control" name="price" type="number" required min="0" />
                                </div>
                                <div className='form-group'>
                                    <label>Mileage</label>
                                    <Field data-testid="mileage" className="form-control" name="mileage" type="number" min="0" required />
                                </div>
                                <div className='form-group'>
                                    <label>Color</label>
                                    <Field data-testid="color" className="form-control" name="color" type="text" required />
                                </div>
                                <div className='form-group'>
                                    <label>Seats</label>
                                    <Field data-testid="seats" className="form-control" name="seats" type="number" required min="1" max="7" />
                                </div>
                                <div className='form-group'>
                                    <label>Fuel</label>
                                    <Field data-testid="fuel" className="form-control" name="fuelType" type="text" required />
                                </div>
                                <div className='form-group'>
                                    <label>Gear</label>
                                    <Field data-testid="gear" className="form-control" name="gearType" type="text" required />
                                </div>
                                <div className='form-group'>
                                    <label>description</label>
                                    <Field data-testid="description" className="form-control" name="description" type="text" required />
                                </div>
                                <div className='form-group'>
                                    <button data-testid="add-btn" type="submit">Add Car</button>
                                </div>
                                <span data-testid="response">{data}</span>
                            </Form>
                        </Formik>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default AddVehicle;