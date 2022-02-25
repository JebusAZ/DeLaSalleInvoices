import React from 'react';

const CustomerEdit = () =>{
    return (

        <React.Fragment>
            <h3 className="mt-3 mb-3">Edit Customer</h3>
            <form>
                <div className="mb-3">
                    <label  className="form-label">Name</label>
                    <input type="name" className="form-control" id="name" aria-describedby="emailHelp"/>
                </div>
                <div className="mb-3">
                    <label className="form-label">RFC</label>
                    <input type="rfc" className="form-control" id="rfc"/>
                </div>
                <div className="mb-3">
                    <label className="form-label">Phone</label>
                    <input type="phone" className="form-control" id="phone"/>
                </div>

                <div className="mb-3">
                    <label className="form-label">Address</label>
                    <input type="address" className="form-control" id="address"/>
                </div>
            
                <button type="submit" className="btn btn-primary">Submit</button>
            </form>
        </React.Fragment>
        /*<div>
            Customers Edit
        </div>*/
    )
}

export default CustomerEdit;