###### .NET PROJECT

<div align="center">

# PARLEZ :speech_balloon:

###### Mandeep Dhillon, Patrick Fortaleza, Juhwan Moon, AJ Purugganan, Kalvin Tang

</div>

</br>
<strong> Live Application: </strong> <a target="blank_" href="https://parlezprod.netlify.app/">Parlez.netlify.app</a> <br/>
<br/>
<strong>App type:</strong> Chat Application<br/>
<strong>Description:</strong> A simple chat/forum application where users are able to create accounts, post messages to a chatroom, read and delete existing messages.
<br/>
</br>

<details>
<summary> :key: &nbsp; INSTALLATION INSTRUCTIONS HERE! </summary>
<br/>
<b>.NET API</b> <br/>
<ol>
    <li>Clone the <a href="https://github.com/BCIT-SSD-2020-21/dotnetproject-team1_netproject">.NET API Repo</a> to your Local machine</li>
    <li>Copy and paste `appsettingsTEMPLATE.json` file and rename the copy to `appsettings.json`</li>
    <li>Update your Connection string to direct it to your local database</li>
    <li>Run `Add-Migrations InitialChatSchema -Context ChatDbContext -OutputDir "Data/Migrations"`</li>
    <li>Then run `Update-Database -Context ChatDbContext`</li>
</ol>
<b>React Client</b>
<ol>
    <li>Clone the <a href="https://github.com/BCIT-SSD-2020-21/dotnetproject-team1_netproject_frontend">React App Repo</a> to your Local machine</li>
    <li>CD into the cloned respository in your local.</li>
    <li>Run `npm install` to install necessary packages</li>
    <li>Run `npm start` to boot up the application</li>
    <li>OPTIONAL: Update the end-points to use your locally running .NET api in `Login.js`, `Registration.js`, `Chatlist.js`, `ChatMessage.js`, and `SubmitMessage.js`</li>
</ol>
</details>

</br>

## :bookmark_tabs: &nbsp; FEATURE LIST

### Core Application Features

1. User authentication
2. Users can post messages
3. User can delete their own messages
4. Users can see the timestamp of each message

### Nice-To-Have Features

1. User can reply to messages
2. Administrators can pin messages
3. Advanced formatting in messages
4. Multiple chatrooms
5. Emoji's / symbols in messages

### Functional Requirements
1. The user interface will allow anonymous chat messages.
2. Users can only delete messages created by their account.
3. The system will require a database that stores messages, and user data.

### Non-functional Requirements

1. The chat application will allow a message object to have a nullable UserId, allowing anon users.
2. Anonymous users must enter in an alias to post a message if they are not authenticated.
3. Each message object will need a user id field.
4. An API will be used to communicate data from the server to the front-end.
5. The application will use ReactJS to send POST/GET/UPDATE/DELETE Requests

## :file_folder: &nbsp; SUPPORTING DOCUMENTS

### Use Case Diagram

<img style="border: solid 1px #ccc" src="https://pfteza-parlez.s3-us-west-2.amazonaws.com/parlez-userdiagram.png" alt="use case diagram for a messenger application" width="100%" />

### Low-Fidelity Prototype:

<img src="https://pfteza-parlez.s3-us-west-2.amazonaws.com/parlez-mockup.png" alt="Low Fidelity for chat application" width="100%" />

### ER Diagram

<img style="border: solid 1px #ccc" src="https://pfteza-parlez.s3-us-west-2.amazonaws.com/parlez-erd.png" alt="ER diagram for chat application" width="100%" />

</br>
