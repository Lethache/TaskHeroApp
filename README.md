TaskHero

TaskHero is a .NET MAUI application that helps a parent turn household chores into clear goals and rewards. A parent creates an account, adds a child, assigns tasks and points, reviews completed work,
creates gifts, and confirms rewards. A child signs in with a child code, views assigned tasks, marks work as complete, tracks a points balance, and claims available gifts.

Project purpose

The application gives families a simple shared workflow:

A parent registers and creates a child profile.

The parent assigns a task, description, child, and point reward.

The child signs in with a child code and marks the task complete.

The parent accepts or rejects the completed task.

An accepted task adds points to the child's balance.

The child can claim a gift when the balance is high enough.


Main user flows

Parent

Register with a login and password.

Add a child name and unique child code.

Create tasks and assign them to a child.

Review completed tasks and accept, reject, or delete them.

Create gifts with a name, description, cost, and image.

Confirm claimed gifts.

Child 

Sign in using the child code.

View assigned tasks in a CollectionView.

Expand a task to read its description, reward, and status.

Mark a task as complete.

View the current points balance.

Browse and claim gifts.
EntranceScreen - Entry point for registration or authorization



ParentRegisterPage - Creates a parent account
<img width="596" height="1080" alt="image" src="https://github.com/user-attachments/assets/a46dac62-3438-4883-be26-0f01caf7b04b" />

ChildAddingPage - Creates a child profile and child code
<img width="611" height="1071" alt="image" src="https://github.com/user-attachments/assets/efdab321-8f43-4829-9b9e-4970ff0f642e" />

AuthorizationPage - Signs in a parent or child

<img width="613" height="1078" alt="image" src="https://github.com/user-attachments/assets/4ba92013-8355-4d2d-b453-c8f350fdd425" />

HomeScreen -Parent dashboard
<img width="594" height="1059" alt="image" src="https://github.com/user-attachments/assets/41193283-b3f2-438f-bc1f-55c095f25b61" />

SetUpTaskPage - Creates and assigns a task
<img width="598" height="1082" alt="image" src="https://github.com/user-attachments/assets/cc771c05-27ea-4bbb-bdc0-80cda532e031" />

CheckDonePage Reviews completed tasks
<img width="614" height="1083" alt="image" src="https://github.com/user-attachments/assets/fe4c3971-a032-4285-9679-07205f7232b9" />



SetUpGiftPage - Creates a reward/gift
<img width="618" height="1073" alt="image" src="https://github.com/user-attachments/assets/18727110-c33f-4118-a92c-36c04ba6d1a2" />

GiveGiftPage - Confirms a claimed gift
<img width="614" height="1092" alt="image" src="https://github.com/user-attachments/assets/952d28b5-5b5f-4cb8-8478-e90bd935e349" />

ChildHomePage - Displays child tasks and balance
<img width="601" height="1085" alt="image" src="https://github.com/user-attachments/assets/575f9418-eeb5-4347-a6d6-b3a1f21047f4" />

ChildGiftShopPage - Displays and claims gifts
<img width="606" height="1067" alt="image" src="https://github.com/user-attachments/assets/f516a3a8-1d53-4ed4-a993-8758824c8115" />


Object-oriented design

TaskHero separates domain objects from manager services and XAML pages:

Account is a reusable base class. Parent and Child inherit from it.

Tasks and Gift encapsulate task and reward state.

AccountManager, TaskManager, and GiftManager own their collections and business operations.

INotifyPropertyChanged supports live XAML binding updates.

Manager services are registered as singletons in MauiProgram, so pages receive shared state through constructor injection.



Demo VIdeo 
https://drive.google.com/file/d/1vIFb9HYl4fSIbNio2nB4Bl3ibKcnJaU1/view?usp=sharing
