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
insert into Users values ('Super Admin','Admin@gmail.com','abc123',3,2)
insert into Users values ('Admin','Admin@gmail.com','abc123',1,2)
insert into Users values ('User','User@gmail.com','abc123',2,2)


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
insert into Tips values('New 1','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book.',1)
insert into Tips values('New 2','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book.',1)
insert into Tips values('New 3','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book.',1)


/* Contest*/
insert into Contests1 values('Recipe Contest','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book',2019-12-23 ,2019-12-24 )
insert into Contests1 values('Tips Contest','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book',2019-12-23 ,2019-12-24 )


/*Participants in contests*/
insert into Participants values ('Recipe of Dessert','Lorem ipsum dolor sit amet, consectetur adipiscing.','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying
 out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is
  thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book',
  1,1)
  insert into Participants values ('Recipe of Dessert','Lorem ipsum dolor sit amet, consectetur adipiscing.','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying
 out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is
  thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book',
  1,2)
    insert into Participants values ('Recipe of Dessert','Lorem ipsum dolor sit amet, consectetur adipiscing.','Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying
 out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is
  thought to have scrambled parts of Cicero s De Finibus Bonorum et Malorum for use in a type specimen book',
  1,3)


  /* Feedback*/
  insert into Feedbacks values(1,'Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying
 out print ')
  insert into Feedbacks values(1,'Lorem ipsum dolor sit amet, consectetur adipiscing.Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying
 out print, graphic or web designs. The passage is attributed ')
   insert into Feedbacks values(3,'Lorem ipsum dolor sit amet, consectetur adipiscing.Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying
 out print, graphic or web designs. The passage is attributed ')
