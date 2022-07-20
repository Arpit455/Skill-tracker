import React from "react";
import { useState } from "react";
const User = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [mobileNumber, setMobileNumber] = useState("");
  const [id, setId] = useState("");
  const [associateid, setAssociateId] = useState("");
  const [message, setMessage] = useState("");
  const [technicalskill, setTechnicalskill] = useState({
    htmlcssjavascript: "",
    angular: "",
    react: "",
    aspdotnetcore: "",
    restful: "",
    entityframework: "",
    git: "",
    docker: "",
    jenkins: "",
    azure: "",
  });
  const [nontechnicalskill, setNonTechnicalskill] = useState({
    spoken: "",
    communication: "",
    aptitude: "",
  });

  var today = new Date();

  let handleSubmit = async (e) => {
    e.preventDefault();
    try {
      let res = await fetch("https://localhost:44384/api/User", {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        method: "POST",
        body: JSON.stringify({
          name: name,
          email: email,
          mobileNo: mobileNumber,
          userId: id,
          associateId: associateid,
          technicalskill: technicalskill,
          nontechnicalskill: nontechnicalskill,
          //createddate: today,
          //lastupdated: today,
        }),
      });
      let resJson = await res.json();
      if (res.status === 200) {
        setName("");
        setEmail("");
        setMobileNumber("");
        setId("");
        setAssociateId("");
        setTechnicalskill("");
        setNonTechnicalskill("");
        setMessage("User created successfully");
      } else {
        setMessage("Some error occured");
      }
    } catch (err) {
      console.log(err);
    }
  };

  return (
    <div className="App">
      <form onSubmit={(e) => handleSubmit(e)}>
      <h3><u>Enter User Details</u></h3>
      <br>
      </br>
        <input
          type="text"
          value={id}
          placeholder="Id"
          onChange={(e) => setId(e.target.value)}
        />
        <br></br>
        <br></br>
        <input
          type="text"
          value={name}
          placeholder="Name"
          onChange={(e) => setName(e.target.value)}
        />
        <br></br>
        <br></br>
        <input
          type="email"
          value={email}
          placeholder="Email"
          onChange={(e) => setEmail(e.target.value)}
        />
        <br></br>
        <br></br>
        <input
          type="text"
          value={mobileNumber}
          placeholder="Mobile Number"
          onChange={(e) => setMobileNumber(e.target.value)}
        />
        <br></br>
        <br></br>
        <input
          type="text"
          value={associateid}
          placeholder="Associateid"
          onChange={(e) => setAssociateId(e.target.value)}
        />
        <br></br>
        <br></br>
        <br></br>
        <h3><u>TechnicalSkills</u></h3>
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.htmlcssjavascript}
          placeholder="htmlcssjavascript"
          onChange={(e) =>
            setTechnicalskill((curr) => ({
              ...curr,
              htmlcssjavascript: e.target.value,
            }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.angular}
          placeholder="angular"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, angular: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.react}
          placeholder="react"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, react: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.aspdotnetcore}
          placeholder="aspdotnetcore"
          onChange={(e) =>
            setTechnicalskill((curr) => ({
              ...curr,
              aspdotnetcore: e.target.value,
            }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.restful}
          placeholder="restful"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, restful: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.entityframework}
          placeholder="entityframework"
          onChange={(e) =>
            setTechnicalskill((curr) => ({
              ...curr,
              entityframework: e.target.value,
            }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.git}
          placeholder="git"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, git: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.docker}
          placeholder="docker"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, docker: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.jenkins}
          placeholder="jenkins"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, jenkins: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={technicalskill.azure}
          placeholder="azure"
          onChange={(e) =>
            setTechnicalskill((curr) => ({ ...curr, azure: e.target.value }))
          }
        />
        <br></br>
        <br></br>
        <br></br>
        <h3><u>NonTechnicalSkills</u></h3>
        <br></br>
        <br></br>
        <input
          type="number"
          value={nontechnicalskill.spoken}
          placeholder="Spoken"
          onChange={(e) =>
            setNonTechnicalskill((curr) => ({
              ...curr,
              spoken: e.target.value,
            }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={nontechnicalskill.communication}
          placeholder="Communication"
          onChange={(e) =>
            setNonTechnicalskill((curr) => ({
              ...curr,
              communication: e.target.value,
            }))
          }
        />
        <br></br>
        <br></br>
        <input
          type="number"
          value={nontechnicalskill.aptitude}
          placeholder="Aptitude"
          onChange={(e) =>
            setNonTechnicalskill((curr) => ({
              ...curr,
              aptitude: e.target.value,
            }))
          }
        />

        {/* <select 
        value={technicalskill} 
        placeholder="TechnicalSkills"
        onChange={(e) => setTechnicalskill(e.target.value)}>
            <option value="grapefruit">Grapefruit</option>
            <option value="lime">Lime</option>
            <option value="coconut">Coconut</option>
            <option value="mango">Mango</option>
          </select>

        <select 
        value={nontechnicalskill} 
        placeholder="NonTechnicalSkills"
        onChange={(e) => setNonTechnicalskill(e.target.value)}>
            <option value="grapefruit">Grapefruit</option>
            <option value="lime">Lime</option>
            <option value="coconut">Coconut</option>
            <option value="mango">Mango</option>
          </select> */}
          <br></br>
        <br></br>

        <button type="submit" className="btn btn-outline-success button rounded-pill">Create</button>

        <div className="message">{message ? <p>{message}</p> : null}</div>
      </form>
    </div>
  );
};

export default User;
