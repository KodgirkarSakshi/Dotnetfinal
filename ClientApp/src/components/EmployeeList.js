import axios from "axios";
import {useEffect, useState} from "react"
const EmployeeList = ()=>{

    const [emparr, setemparr]= useState([]);

    useEffect(()=>{
        // this.populateEmployees();
         
        axios.get("https://localhost:7028/employee").then(response=>{
            console.log(response)
            setemparr(response.data);
        })
    }, []);
    // async populateEmployees=async ()=> {
    //     const response =  await fetch('employees');
    //     const data = await response.json();
    //     setemparr(data);
    
    
    return(
        <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Email</th>
            <th>Address</th>
            <th>Password</th>
            <th>Deptid</th>
            <th>Managerid</th>
          </tr>
        </thead>
        <tbody>
          {emparr.map(emp =>
            <tr key={emp.id}>
              <td>{emp.id}</td>
              <td>{emp.name}</td>
              <td>{emp.email}</td>
              <td>{emp.address}</td>
              <td>{emp.password}</td>
              <td>{emp.deptid}</td>
              <td>{emp.managerid}</td>
            </tr>
          )}
        </tbody>
      </table>
        )
      

}
export { EmployeeList};