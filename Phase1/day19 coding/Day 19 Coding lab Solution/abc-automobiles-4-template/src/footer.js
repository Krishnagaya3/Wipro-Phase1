import React from 'react';
import { ReactDOM } from 'react';

function Footer() {
    //create the footer content using data-testid="footer-content"
    return (
        <div data-testid="footer-content">
            <div className='row'>
                <div className='col-12'>
                    <div className='footer'>
                        <a href='#'> @Copyright 2024. </a>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Footer;