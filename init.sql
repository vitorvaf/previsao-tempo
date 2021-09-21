--Create a new sample databse and grant all privilgies
SELECT 'CREATE DATABASE searchweather'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'searchweather')\gexec
grant all privileges on database searchweather to postgres;

CREATE TABLE search_user (
  id SERIAL PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  temp INTEGER NOT NULL,
  weather TEXT NOT NULL,
  icon TEXT NOT NULL,
  creationDate DATE NOT NULL

);
