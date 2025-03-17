import React from 'react';
import { Link } from 'react-router-dom';

function Menu() {
    return (
        
        <div data-testid="menu-content">
            <nav className="navbar navbar-expand-lg">
                <div className="container-fluid">
                    <Link className="navbar-brand" to="/">ABC Automobiles</Link>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <Link className="nav-link" to="/"> Home </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/about" data-testid="about-menu"> About Us </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/vehicle-list">Vehicles</Link>
                            </li>
                            <li className="nav-item">
                                <Link target='_blank' className="nav-link" to="/vehicle-add">Add Vehicle</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/">Contact Us</Link>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    )
}

export default Menu;