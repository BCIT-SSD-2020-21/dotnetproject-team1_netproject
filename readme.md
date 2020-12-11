###### .NET PROJECT

<div align="center">

## PARLEZ :speech_balloon:

###### Mandeep Dhillon, Patrick Fortaleza, Juhwan Moon, AJ Purugganan, Kalvin Tang

</div>

</br>

<strong>App type:</strong> Chat Application<br/>
<strong>Description:</strong> A simple chat/forum application where users are able to create accounts, post messages to a chatroom, read and delete existing messages, as well as interact with other user's messages.

</br>

<details>
<summary>  INSTALLATION INSTRUCTIONS HERE! </summary>
<br/>

1. Clone this Repo to your Local machine
2. Copy and paste ` appsettingsTEMPLATE.json` file and rename the copy to ` appsettings.json`
3. Update your Connection string to direct it to your database
4. Run ` Add-Migrations InitialChatSchema -Context ChatDbContext -OutputDir "Data/Migrations"`
5. Then run ` Update-Database -Context ChatDbContext`

</details>

</br>

### FEATURE LIST

#### End Users

1. Users can create accounts and authenticate to view the chat room messages
2. Users can post messages
3. Users can delete their own messages
4. User can update their display name, and profile picture
5. Users can upvote/downvote messages and replies
6. Users can see the timestamp of each message

### CORE APPLICATION FEATURES

1. User authentication
2. Users can post messages
3. Users can upvote/downvote messages
4. User can delete their own messages
5. Users can update their profile, and have it reflect in chat
6. Users can see the timestamp of each message
7. Administrators can ban users

### NICE-TO-HAVE FEATURES

1. User can reply to messages
2. Administrators can pin messages
3. Advanced formatting in messages
4. Multiple chatrooms
5. Emoji's / symbols in messages

### FUNCTIONAL REQUIREMENTS

1. The user interface will only allow access to chat messages if a user has registered and is authenticated.
2. The system will only allow administrators to perform data updates on other user profiles not owned by them.
3. Only administrators have access to the admin panel.
4. The admin panel will be a singular panel where admin actions are only 2-3 clicks away from the main chat screen.
5. Users can only delete messages created by their account.
6. The system will require a database that stores messages, and user data.

### NON-FUNCTIONAL REQUIREMENTS

1. The chat application will need to verify the authenticated user before each request is sent to the server using JSON Web Tokens.
2. The admin panel will be a protected route.
3. An API will be used to communicate data from the server to the front-end
4. The application will use ReactJS to send POST/GET/UPDATE/DELETE Requests
5. Message data will only include text content that will be encoded into HTML when put into the database, and decoded into formatted text on the front-end.

### Use Case Diagram

<img src="https://pfteza-etc.s3-us-west-2.amazonaws.com/parlez-usecase.png" alt="use case diagram for a messenger application" width="100%" />

### Low-Fidelity Prototype:

<img src="https://parlez.s3.ca-central-1.amazonaws.com/MockUp1.jpg" alt="Low Fidelity for chat application" width="100%" />

<img src="https://parlez.s3.ca-central-1.amazonaws.com/MockUp2.jpg" alt ="Low Fidelity for chat application" width="100%" />

### ER Diagram

<img src="https://parlez.s3.ca-central-1.amazonaws.com/parlezV3.jpg" alt="ER diagram for chat application" width="100%" />

</br>

<details>
<summary>  Potential Future Updates </summary>

</br>

1. Users can reply to an existing messages
2. Admin user privileges
3. See who is typing
4. See who read the message

</details>
