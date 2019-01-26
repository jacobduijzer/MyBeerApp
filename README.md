| develop | master |
| --- | --- |
| [![Build Status](https://dev.azure.com/JDuijzer/MyBeerApp/_apis/build/status/jacobduijzer.MyBeerApp?branchName=develop)](https://dev.azure.com/JDuijzer/MyBeerApp/_build/latest?definitionId=4?branchName=develop) | [![Build Status](https://dev.azure.com/JDuijzer/MyBeerApp/_apis/build/status/jacobduijzer.MyBeerApp-master?branchName=master)](https://dev.azure.com/JDuijzer/MyBeerApp/_build/latest?definitionId=5?branchName=master) |

# MyBeerApp

Nothing about beer here. I am trying to create a clean project structure with "Clean Architecture". What I am trying to achieve is a clean solution
with unit tests, integration tests and a containerized environment.

# Highlights

## Integration tests

Using the TestHost with stubbed data to test both a mvc site and an api project. Custom test fixture to use a separate in-memory test database for the api and the web while using only one test project.

[links here]

## Dockerfile's with unit- and integration tests

Before the final docker images are created both the unit tests and the integration tests will run.