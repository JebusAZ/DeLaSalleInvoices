import React from 'react';
import {BrowserRouter,Route,Routes} from 'react-router-dom';

import Navigation from './components/navigation/Navigation';
import Home from './containers/Home';
import Customers from './containers/Customers';
import './navbar-top-fixed.css';


export default function App(){
    return (
        <BrowserRouter>
            <Navigation/>
            <main className='container'>
                <Routes>
                    <Route path ="/" element={<Home/>}></Route>
                    <Route path ="/customers" element={<Customers/>}></Route>
                </Routes>  
            </main>
       </BrowserRouter>
    );
}