import React from "react";
import Button from "react-bootstrap/Button";
import { useNavigate } from "react-router-dom";

const Home = () => {
  const navigate = useNavigate();

  return (
    <div className="Home">
      <header className="App-header">
        <h1><u className="underline">Skill Tracker</u></h1>
        <br></br>
      </header>
      <div className="Wrapper">
      <Button onClick={() => navigate("userprofile")} variant="outline-primary rounded-pill">
        Add User Profile
      </Button>
      <br></br>
      <Button onClick={() => navigate("updateprofile")} variant="outline-secondary rounded-pill">Edit User Profile</Button> <br></br>
      <Button onClick={() => navigate("getuser")} variant="outline-success rounded-pill">Admin</Button>
      </div>
    </div>
  );
};

export default Home;
