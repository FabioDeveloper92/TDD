# TDD

It's a very powerful approach to build robust software.
In this repository, I write some example how to build it

## How to Start

1. Write requirements of your functionality
2. Write a test for the first requirement, this test will fail (red situation)
3. Resolve the test is fail, now if the test work you are in green situation
4. Run all tests you have written because it could be that your fix would have created a bug
4A. If you have red tests, you must resolve their and rerun all tests
5. Repeat this sequence from step 2

## Pro

1. Modular Design

    Developers understand and learn the principles of modular design.
The problems of a possible wrong architecture can be detected immediately in the first stages of development.

2. Easy Refactor/ Maintenance

    By creating tests you can make fix changes without worrying about what impact it will have on other features, because once you have finished your change by launching all the tests you will immediately see if there are errors.

3. Code Documentation

    Giving meaningful names to the methods you will immediately understand the purpose of the test, moreover in the tests there will usually be code used also in the production phase.

4. Collaboration

    You can work on parts of the code not written by you because from the tests you begin to understand what a certain method is doing.
