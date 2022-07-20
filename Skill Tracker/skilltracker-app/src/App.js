import React from "react";
import { Link } from "react-router-dom";
import { BrowserRouter, Routes, Route } from "react-router-dom";

import User from "./containers/User/User";
import FindUser from "./containers/User/FindUser";
import EditUser from "./containers/User/EditUser";

const App = () => {
  return (
    <BrowserRouter>
      <div className="Home">
        <header className="App-header">
          <Link to="/">
            <h1>Skill Tracker</h1>
          </Link>
          <div className="wrapper">
            <Link to="userprofile" className="btn btn-outline-primary">
              Add User Profile
            </Link>
            <Link to="updateprofile" className="btn btn-outline-secondary">
              Edit User Profile
            </Link>
            <Link to="getuser" className="btn btn-outline-success">
              Admin Panel
            </Link>
          </div>
        </header>
        <Routes>
          <Route index element={<div />} />
          <Route path="userprofile" element={<User />} />
          <Route path="getuser" element={<FindUser />} />
          <Route path="updateprofile" element={<EditUser />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
};

export default App;
