import React from 'react';
import { NavLink } from 'react-router-dom';

const Navigation = () =>{
    return (<nav className="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
    <div className="container-fluid">
        <a className="navbar-brand" href="/">DeLaSalle Invoices</a>
        <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
        <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarCollapse">
        <ul className="navbar-nav me-auto mb-2 mb-md-0">
            
            <li className="nav-item">
                <NavLink className="nav-link active" to="/" >Home</NavLink>
            </li>
            <li className="nav-item">
                <NavLink className="nav-link active" to="/customers" >Customers</NavLink>
            </li>
            <li className="nav-item">
                <NavLink className="nav-link active" to="/invoices" >Invoices</NavLink>
            </li>

        </ul>
        </div>
    </div>
</nav>
        
        
        
        
        /*<div>
            <NavLink to ="/">Home</NavLink>
            <NavLink to ="/customers">Customers</NavLink>
        </div>*/
    )
}

export default Navigation;