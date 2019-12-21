/*Step1 Create*/
Create database JamesThewDOTcom
/*Step2 Use*/
use JamesThewDOTcom
/*Step 3 After Generate database from model*/
/*For Roles*/
insert into Roles values('Admin'),('User'),('SuperAdmin')
/*for submision type*/
insert into  Subscription_Type values('Monthly$10'),('yearly$100')
/*for Super Admin*/
insert into Users(User_Name,Email,Password) values ('Super Admin','Admin@gmail.com','abc123',3,2)
/*Insert in reripe table for tril*/
insert into Recipes1 values( 'Dessert','psum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero',
1,'Images/recipe3092719727.jpg','Paid')
insert into Recipes1 values( 'vegitarian recipe','psum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero',
1,'Images/recipe2092819407.jpg','Free')
insert into Recipes1 values( 'other','psum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero',
1,'Images/recipe1092921308.jpg','Paid')
insert into Recipes1 values( 'Italian','psum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero',
1,'Images/recipe1092921308.jpg','Free')

/*insert in tips */
insert into Tips values('New 1','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book.',9)
insert into Tips values('New 2','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book.',9)
insert into Tips values('New 3','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book.',9)



