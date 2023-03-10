# Facebook Post

## What is the problem to be solved?
Depending of the ammount of names typed by the user, the program has to show a message like the information of a Facebook post. 

## What do I know?
1. If no one likes your post, it doesn't display anything. 
2. If only one person likes your post it displays: [Friend] likes your post.
3. If two people like your post, it display: [Friend 1] and [Friend 2] like your post.
4. If more than 2 people like your post, it displays: [Friend1], [Friend2] and [Number of other people] others like your post


## What do I need from the user? 
The input of the names.

## What will my program produce?
The message depending the scenarios.

## Pseudocode
1. Ask the user to type the names until he press enter.
2. Store the names.
3. Get the amount of names
4. If amount is equal to zero display message 1.
5. If amount is equal to one display message 2.
6. If amount is equal to two display message 3.
7. If amount is greater than two display message 4. And substract 2 of the amount of names. 

## Flow Diagram
![Flow](img/Facebook%20Post.png)

## Test Cases
User type:

* "" => Message: 
* "Carlos" => Message: "Carlos likes your post"
* "Carlos Juan" => Message: "Carlos and Juan like your post"
* "Carlos Juan Pedro Pepe" => Message: "Carlos, Juan and 2 others like your post"