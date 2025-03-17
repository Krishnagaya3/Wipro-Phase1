import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import About from './about';
import { BrowserRouter, Outlet } from 'react-router-dom';
import { Route, Routes } from 'react-router-dom';
import reportWebVitals from './reportWebVitals';
import VehicleList from './vehicle-list';
import AddVehicle from './add-vehicle';


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <div className='container'>
      <BrowserRouter basename='/'>
        <Routes>
          <Route index element={<App />} />
          <Route path="/about" element={<About />} />
          <Route path="/vehicle-list" element={<VehicleList />} />
          <Route path="/vehicle-add" element={<AddVehicle />} />
        </Routes>
      </BrowserRouter>
      <Outlet></Outlet>
    </div>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();