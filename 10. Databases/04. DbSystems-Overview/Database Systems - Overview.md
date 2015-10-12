# Answer following questions in Markdown format (.md file)

## 1. What database models do you know?
------
Relational model - a way to make database management systems more independent of any particular application;
three key terms are used extensively in relational database models: relations, attributes, and domains;
a relation is a table with columns and rows. The named columns of the relation are called attributes, and
the domain is the set of values the attributes are allowed to take.

## 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
------
A relational DBMS is special system software that is used to manage the organization, storage, access,
security and integrity of data. This specialized software allows application systems to focus on the
user interface, data validation and screen navigation.  When there is a need to add, modify, delete or
display data, the application system simply makes a "call" to the RDBMS.

## 3. Define what is "table" in database terms.
------
In relational databases and flat file databases, a table is a set of data elements (values) using a model
of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and
column intersect. A table has a specified number of columns, but can have any number of rows.
Each row is identified by one or more values appearing in a particular column subset. The columns
subset which uniquely identifies a row is called the primary key.

"Table" is another term for "relation"; although there is the difference in that a table is usually
a multiset (bag) of rows where a relation is a set and does not allow duplicates. Besides the actual
data rows, tables generally have associated with them some metadata, such as constraints on the
table or on the values within particular columns

## 4. Explain the difference between a primary and a foreign key.
------
**Primary key:**
It will not allow "Null values" and "Duplicate values"

**Foreign key:**
It will allow "Null values" and "Duplicate values" and it refers to a primary key
in another table

## 5. Explain the different kinds of relationships between tables in relational databases.
------
There are three types of relationships between tables. The type of relationship that is created depends on how
the related columns are defined:

* **One-to-Many Relationship**
* **Many-to-Many Relationships**
* **One-to-One Relationships**

### One-to-Many Relationships

A one-to-many relationship is the most common type of relationship. In this type of relationship, a row in table A
can have many matching rows in table B, but a row in table B can have only one matching row in table A.
For example, the publishers and titles tables have a one-to-many relationship: each publisher produces many titles,
but each title comes from only one publisher. Make a one-to-many relationship if only one of the related columns is
a primary key or has a unique constraint. The primary key side of a one-to-many relationship is denoted by a key symbol.
The foreign key side of a relationship is denoted by an infinity symbol.

### Many-to-Many Relationships

In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. You create
such a relationship by defining a third table, called a junction table, whose primary key consists of the foreign
keys from both table A and table B. For example, the authors table and the titles table have a many-to-many relationship
that is defined by a one-to-many relationship from each of these tables to the titleauthors table. The primary key of
the titleauthors table is the combination of the au_id column (the authors table's primary key) and the title_id column (
the titles table's primary key).

### One-to-One Relationships

In a one-to-one relationship, a row in table A can have no more than one matching row in table B, and vice versa.
A one-to-one relationship is created if both of the related columns are primary keys or have unique constraints.
This type of relationship is not common because most information related in this way would be all in one table.
You might use a one-to-one relationship to:
* Divide a table with many columns.
* Isolate part of a table for security reasons.
* Store data that is short-lived and could be easily deleted by simply deleting the table.
* Store information that applies only to a subset of the main table.
* The primary key side of a one-to-one relationship is denoted by a key symbol. The foreign key side is also denoted
  by a key symbol.
