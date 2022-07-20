import React from "react";
import { useState } from "react";

function FindUser() {
  
  const [message, setMessage] = useState("");
  const [criteria, setcriteria] = useState("");
  const [criteriavalue, setcriteriavalue] = useState("");

  var today = new Date();

  let handleSubmit = async (e) => {
    e.preventDefault();
    try {
      let res = await fetch(
        `https://localhost:44384/api/skilltracker/admin/${criteria}/${criteriavalue}`,
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
          },
          method: "GET",
          body: JSON.stringify({
            criteria:criteria,
            criteriavalue:criteriavalue,
          }),
        }
      );
      let resJson = await res.json();
      if (res.status === 200) {
        
        setcriteria("");
        setcriteriavalue("");
        setMessage("User created successfully");
      } else {
        setMessage("Some error occured");
      }
    } catch (err) {
      console.log(err);
    }
  };
  return (
    <div className= "Apps">
     
      <form onSubmit={(e) => handleSubmit(e)}>
       <h3><u>Find User Profile</u></h3>
       <br></br>
       <br></br>
       <br></br>
       <input
          type="text"
          value={criteria}
          placeholder="Criteria"
          onChange={(e) => setcriteria(e.target.value)}
        />
        <br></br>
       <br></br>
        <input
          type="text"
          value={criteriavalue}
          placeholder="CriteriaValue"
          onChange={(e) => setcriteriavalue(e.target.value)}
        />
        
        <br></br>
       <br></br>
        <button type="submit" className="btn btn-outline-success button rounded-pill">Create</button>

<div className="message">{message ? <p>{message}</p> : null}</div>
      </form>
    </div>
  );
}

export default FindUser;