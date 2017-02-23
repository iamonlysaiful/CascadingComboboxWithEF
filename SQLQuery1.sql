CREATE TABLE country
  (
     countryID     INT Identity(1,1) NOT NULL,
     countryName   varchar(50) NOT NULL,
     PRIMARY KEY (countryID ),
  );
  Go

CREATE TABLE state
  (
 stateID     INT Identity(200,1) NOT NULL,
 countryID INT NOT NULL,
 stateName   varchar(50) NOT NULL,
 PRIMARY KEY (stateID ),
 FOREIGN KEY (countryID ) REFERENCES country (countryID));
 Go

CREATE TABLE city
  (
cityID     INT  Identity(300,1) NOT NULL,
 stateID INT NOT NULL,
 cityName   varchar(50) NOT NULL,
 PRIMARY KEY (cityID),
 FOREIGN KEY (stateID) REFERENCES state (stateID));