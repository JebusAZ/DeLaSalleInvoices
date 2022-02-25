import React from 'react';


const CustomerList = () =>{
    return (

        <React.Fragment>

            <h3 className="mt-3 mb-3">Customers</h3>

            <div className="row mb-3">
                <div className="col6">
                    <input type="text" className="form-control" placeholder="Name or RFC" aria-label="First name"/>
                </div>
                <div className="col">
                    
                </div>
            </div>
            <table className="table">
            <thead>
                <tr>
                <th scope="col">#</th>
                <th scope="col">Name</th>
                <th scope="col">RFC</th>
                <th scope="col">Actions</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                <th scope="row">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td></td>
                </tr>
                <tr>
                <th scope="row">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td></td>
                </tr>
                <tr>
                <th scope="row">3</th>
                <td>Larry</td>
                <td>the Bird</td>
                <td></td>
                </tr>
            </tbody>
            </table>
        </React.Fragment>
        /*<div>
            Customer List
        </div>*/
    )
}

export default CustomerList;