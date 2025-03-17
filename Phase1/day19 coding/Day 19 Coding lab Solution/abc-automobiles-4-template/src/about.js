import React, { useState } from 'react';
import { ReactDOM } from 'react';
import Nav from './nav';

function About() {
    //create the about content using data-testid="about-content"
    return (
        <div>
            <Nav></Nav>
            <div data-testid="about-content">
                <div className='row'>
                    <div className='col-12'>
                        <h2>About Us</h2>
                        <p>
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                        </p>
                    </div>
                </div>

                <div className='row'>
                    <div className='col-12'>
                        <div className="card-group">
                            <div className="card">
                                <img src="https://imgd.aeplcdn.com/310x174/n/cw/ec/130591/fronx-exterior-right-front-three-quarter-109.jpeg?isig=0&q=80" className="card-img-top" alt="..." />
                                <div className="card-body">
                                    <h5 className="card-title">Maruti Fronx</h5>
                                    <p className="card-text">Maruti Fronx price for the base model starts at Rs. 8.99 Lakh and the top model price goes upto Rs. 16.16 Lakh. Fronx price for 14 variants is listed below.</p>
                                    <p className="card-text"><small className="text-body-secondary">Last updated 3 mins ago</small></p>
                                </div>
                            </div>
                            <div className="card">
                                <img src="https://imgd.aeplcdn.com/310x174/n/cw/ec/168697/creta-n-line-exterior-right-front-three-quarter-2.png?isig=0&q=80" className="card-img-top" alt="..." />
                                <div className="card-body">
                                    <h5 className="card-title">Hyundai Creta N Line</h5>
                                    <p className="card-text">Hyundai Creta N Line price for the base model starts at Rs. 20.92 Lakh and the top model price goes upto Rs. 25.77 Lakh. Creta N Line price for 12 variants is listed below.</p>
                                    <p className="card-text"><small className="text-body-secondary">Last updated 3 mins ago</small></p>
                                </div>
                            </div>
                            <div className="card">
                                <img src="https://imgd.aeplcdn.com/310x174/n/cw/ec/40432/scorpio-n-exterior-right-front-three-quarter-75.jpeg?isig=0&q=80" className="card-img-top" alt="..." />
                                <div className="card-body">
                                    <h5 className="card-title">Mahindra Scorpio N</h5>
                                    <p className="card-text">Mahindra Scorpio N price for the base model starts at Rs. 17.13 Lakh and the top model price goes upto Rs. 31.08 Lakh. Scorpio N price for 34 variants is listed below.</p>
                                    <p className="card-text"><small className="text-body-secondary">Last updated 3 mins ago</small></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default About;