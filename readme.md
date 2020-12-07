## PROJECT
<strong>App name:</strong> Parlez
<strong>Description:</strong> 
Users are able to create accounts, and authenticate to log into an accessible forum, where they can post messages and reply to messages from other users.

### Feature List
1. Users can create accounts and authenticate to view the chat room messages
  1.1 Username
  1.2 Email
  1.3 Password
  1.4 Profile Picture
2. Post messages, reply to messages
  2.1 Text-Only messages
  2.2 Simple formatting -> Bolds, Italics, Underlines
3. User can delete their own messages
4. User can update their display name, and picture
5. Users can upvote/downvote messages
6. Users can see the timestamp of each message
8. English only
9. User bans 

### Functional Requirements
1. User authentication
2. User Post messages
3. User can reply to messages
4. User can delete their own messages
5. English only
6. Users can update their profile, and have it reflect in chat

### Non Functional
1. Users can upvote/downvote messages
2. Users can see the timestamp of each message
3. Pin Messages
4. User bans
5. Advanced formatting in messages
6. Multiple chatrooms
7. Emoji's / symbols in messages

### TECHNICAL REQUIREMENTS
1. Authentication to allow users to view chat
  - Auth requires: Users to input username, email, password, image
  - store text data, and an image url
  - Some way to hash a password
  - Need a way to keep track of sessions, and login data
    - The application will need to know who is posting, or replying to a message
  - Have a storage place for the user's images, and reference that url in the DB
2. User Database:
  - Store user information
  - username, email, password, profile image
3. Messages Database:
  - Will store all messages,
  - Replies to messages are stored here as well
  - Upvote/downvote data
  - Timestamp data
  - Message data type:
    - HTML/Raw text







