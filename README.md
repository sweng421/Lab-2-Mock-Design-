# M3 Lab

## Project Description

XYZ company consists of a number of people, including nine employees and one owner (Craig).

All ten people share these attributes: name, age, title and salary. Non-sharable attributes can be added freely. For
the nine employees, John and Mary are managers, Jane and Joe are accountants, and the others are
blacksmiths including Jack, Katie, Amy, Lin, and Greg. 

Employees of the same job title have an identical
start-up stipend. The salary can grow over time above the start-up stipend according to the individual
performance. The start-up stipend is $50,000 for manager, $45,000 for accountant, and $35,000 for
blacksmith.

The owner can send a text message to multiple employees at a time. When out of town, the owner can
assign this duty to one of the managers only. 

A manager can evaluate the performance of accountants or
blacksmiths one at a time and ranks a Likert scale between 1 and 5. When a manager is out of town, the
evaluation duty is handled by another manager. 

An accountant can update the salary of an employee at a
time. When out of town, an accountant asks the other accountant for help no others. Very importantly,
only accountants can update salary. 

A blacksmith can perform an assigned task object. A task object has
an ID, due date, and description as the attributes. When out of town, a blacksmith can ask a blacksmith, a
manager, or even an accountant for help to work on the assigned duty. 

For simplicity, assume one person
can do only one extra work besides his own work.

Craig sends a message “Good Job” to employees John, Jane and Jack through the accepted argument. 

Greg not only performs his own task t1
but also the task t2 from Amy. In other words, calling Greg’s perform method will do both tasks and
prompt two simple messages related to the tasks. 

Accountant Jane updates Greg’s salary with an increase
of $1000 and helps Lin to do his task. 

Originally, John and Mary should evaluate Jack and Katie,
respectively. However, John receives an urgent notice to go out of town and asks Mary for help. Finally,
run Mary’s “evaluate” method that assigns the individual Likert scales for Jack and Katie as 4 and 5.
