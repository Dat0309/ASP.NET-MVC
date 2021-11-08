import React, { Component } from 'react';

export class FetchEmployee extends Component {

    constructor(props) {
        super(props);
        this.state = { empList: [], loading: true };

        //this.handleDelete = this.handleDelete.bind(this);
        //this.handleEdit = this.handleEdit.bind(this);
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderEmployeeTable(this.state.empList);

        return (
            <div>
                <h1>Employee Data</h1>

                <p>This component demonstrates fetching Employee data from the server.</p>
                <p>This component demonstrates fetching Employee data from the server.</p>
                {contents}
            </div>
        );

    }

    renderEmployeeTable(empList) {
        return (<table classname='table'>
            <thead>
                <tr>
                    <th></th>
                    <th>EmployeeId</th>
                    <th>Name</th>
                    <th>Gender</th>
                    <th>Department</th>
                    <th>City</th>
                </tr>
            </thead>
            <tbody>
                {empList.map(emp =>
                    <tr key={emp.employeeId}>
                        <td></td>
                        <td>{emp.EmployeeId}</td>
                        <td>{emp.Name}</td>
                        <td>{emp.Gender}</td>
                        <td>{emp.Department}</td>
                        <td>{emp.City}</td>
                    </tr>
                )}
            </tbody>
        </table >
        );
    }
}