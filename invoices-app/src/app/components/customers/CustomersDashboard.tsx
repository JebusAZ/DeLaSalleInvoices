import React from 'react';
import CustomerEdit from './CustomerEdit';
import CustomerList from './CustomerList';

const CustomersDashboard = () =>{
    return (
        <div>
            <h1>Customers</h1>
            <CustomerList></CustomerList>
            <CustomerEdit></CustomerEdit>
        </div>
    )
}

export default CustomersDashboard;