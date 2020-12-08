###### .NET PROJECT
## PARLEZ CHAT APPLICATION
###### Mandeep Dhillon, Patrick Fortaleza, Juhwan Moon, AJ Purugganan, Kalvin Tang
<strong>App name:</strong> Parlez <br/>
<strong>Description:</strong> A simple chat/forum application where users are able to create accounts, post messages to a chatroom, read and reply to existing comments, as well as interact with other user's messages.

### FEATURE LIST
#### End Users
1. Users can create accounts and authenticate to view the chat room messages
2. Users can post messages, and reply to existing messages
3. Users can delete their own messages
4. User can update their display name, and profile picture
5. Users can upvote/downvote messages and replies
6. Users can see the timestamp of each message
#### Admin Users
9. Administrators can ban users
10. Administrators can update user profile details

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
<img src="https://pfteza-etc.s3-us-west-2.amazonaws.com/parlez-usecase.png" alt="use case diagram for a messenger application" />


### Low-Fidelity Prototype: 

https://xd.adobe.com/view/d00e5bba-fc29-4581-9d1a-7b1729e707eb-855d/

![](https://i.imgur.com/8cym8Zu.png)

![](https://i.imgur.com/GIupcl2.png)






