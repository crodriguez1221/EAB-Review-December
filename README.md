# Washington Vets 2 Tech (WAV2T)

### Computer Science Capstone Award — Hal and Inge Marcus School of Engineering, Saint Martin's University

Washington Vets 2 Tech (WAV2T) is a client-based computer science capstone project developed for the Engineering Advisory Board (EAB) at Saint Martin's University.

The project involved the design and development of a prototype web-based learning platform intended to support veterans preparing for technical education pathways. The platform was designed to provide centralized study resources, student accounts, adaptive readiness assessments, persistent learning progress, administrative content management, and AI-assisted access to educational material.

The capstone encompassed stakeholder collaboration, requirements engineering, system design, Software Requirements Specification (SRS) development, architecture and interface design, backend and frontend development, adaptive assessment development, AI chatbot development, administrative tooling, cloud-integration research, prototype demonstrations, and final technical documentation.

> **Repository Notice**
>
> This repository is an archival and portfolio snapshot of the WAV2T academic capstone and **does not contain the complete source code developed during the project**.
>
> Because WAV2T was developed as a client-based academic project, only selected project artifacts and portions of the prototype were committed to the public GitHub repository. Additional functionality—including the Django adaptive assessment implementation, persistent user-progress tracking, Django administrative functionality, and AI chatbot development—is not fully represented by the source files currently preserved here.
>
> The midyear and final capstone presentations linked below provide supporting documentation of functionality and development work beyond the public repository snapshot.

---

### About the BattleBuddy Name

During development, the team used **BattleBuddy** as the working name for the WAV2T platform. 
References to BattleBuddy in project documentation and presentations refer to the same 
Washington Vets 2 Tech (WAV2T) capstone project described in this repository.

---

## Project Objective

WAV2T was designed to help students preparing for technical training evaluate their current knowledge, identify areas requiring additional study, and access educational resources before attempting pathway entrance examinations.

The proposed platform combined several capabilities into a single student-facing system:

- Student registration and authentication
- Student portal functionality
- Centralized study materials and educational resources
- Technical training pathway information
- Adaptive readiness assessments
- Persistent student assessment progress
- Topic-based performance tracking
- Personalized study guidance
- Administrative management of assessment and training content
- AI-assisted interaction with instructional material

Rather than functioning solely as a static informational website, WAV2T combined student-performance tracking and educational content to support a more personalized learning experience within the prototype.

---

## Adaptive Assessment System

A major component implemented during the capstone was an **adaptive assessment system** designed to evaluate a student's current knowledge level and dynamically adjust question difficulty based on performance.

Assessment questions were organized by both topic and difficulty.

Example topic categories included:

- Cybersecurity
- Networking
- Cloud
- Computer fundamentals

Questions could be assigned difficulty levels such as:

- Easy
- Medium
- Hard

The Django backend maintained a student's current progress and used that information when selecting subsequent questions.

Rather than presenting every student with the same static sequence of questions, the assessment could adjust question difficulty as the student's performance changed.

This provided a foundation for identifying a student's approximate level of readiness and directing the student toward areas requiring additional study.

---

### Persistent Student Progress

The Django implementation included persistent assessment-progress tracking associated with authenticated users.

The system tracked information including:

- User
- Assessment topic
- Current difficulty level
- Correct-answer count
- Incorrect-answer count

Progress was maintained by topic, allowing a student's performance to evolve as they continued studying and completing assessments.

This architecture supported the broader goal of creating an assessment experience that responded to an individual student's learning progress rather than treating every quiz attempt as an isolated event.

---

### Authentication and Student Accounts

Authentication and account-management functionality was developed as part of the student portal prototype.

Prototype account-management development included:

- User registration
- Login
- Password handling
- Password-reset workflow
- Authenticated access to application functionality
- Association of assessment progress with individual users

The public repository currently preserves portions of an ASP.NET Core Identity implementation related to this functionality.

Additional Django-based development used authenticated users when maintaining individual assessment progress.

---

### Django Administration

Django's administrative interface was incorporated into the prototype to provide a practical way to manage educational and assessment content without requiring direct database manipulation.

Administrative functionality supported management of data such as:

- Users
- Subjects
- Assessment questions
- Answers
- Question difficulty
- Training materials
- Entrance-exam content
- User performance
- Course-completion information

This provided a centralized content-management interface through which assessment and training information could be updated as educational material or program requirements changed.

---

## AI Chatbot Development

The WAV2T prototype also included development of an AI-assisted chatbot intended to help students interact with educational content and obtain information from available training material.

Existing Vets 2 Tech instructional presentations were used as source material for chatbot development.

The chatbot prototype included work involving:

- Extracting instructional content from presentation material
- Processing course content for use by the chatbot
- Generating structured question-and-answer material
- OpenAI API integration
- Prompt development
- Transforming concise instructional content into conversational responses
- Organizing generated educational content
- Managing chatbot-related training material through the application's administrative tools

The chatbot represented a capstone prototype rather than a production AI system.

Portions of the chatbot pipeline and administrative functionality are demonstrated in the final capstone presentation.

---

## Frontend and Interface Development

The project included multiple frontend and interface-development efforts.

Application-integrated frontend work was developed to connect users with backend functionality such as:

- Authentication
- Student account functionality
- Study resources
- Assessment functionality
- Application navigation

Wireframes were also developed to define intended page structure, user flow, and interaction between major components before and during implementation.

Separate standalone HTML frontend prototypes were also developed during the project. These prototypes were developed separately from the application's backend and were not integrated with the adaptive assessment system, authentication, Django administrative functionality, or other application services.

---

## System Design and Architecture

The project included system-design work intended to translate stakeholder requirements into a proposed technical architecture.

Design artifacts included:

- Application wireframes
- UML diagrams
- Layered architecture diagrams
- System component planning
- Data-model planning
- User-flow design
- Backend/frontend interaction planning

These artifacts supported both prototype implementation and communication of the proposed system architecture in the project's technical documentation.

---

## Requirements Engineering & Technical Documentation

WAV2T was developed as a client-oriented software engineering project, with formal requirements gathering, system design, and technical documentation forming a significant part of the capstone.

### Software Requirements Specification (SRS)

The project's Software Requirements Specification was **co-authored by Beth Gallatin and Connie Rodriguez** and developed through stakeholder collaboration and requirements analysis.

The SRS documented areas including:

- Project purpose and scope
- Stakeholder and user requirements
- Functional requirements
- Non-functional requirements
- System constraints
- Proposed system functionality
- Use cases and user interactions
- System and interface requirements

A portfolio excerpt containing the opening portion of the original SRS is provided to demonstrate the requirements-engineering process while limiting public distribution of the complete client project documentation.

[View the SRS Portfolio Excerpt](docs/WAV2T-SRS-Portfolio-Excerpt.pdf)

### Final Technical Report

A separate final technical report documented the system design, prototype implementation, technical decisions, and results of the completed capstone.

The final technical report was **authored by Connie Rodriguez and edited by Beth Gallatin**.

Technical and design artifacts created by Connie for the project and incorporated into the documentation included:

- UML diagrams
- Layered architecture diagrams
- System-design documentation
- Project wireframes
- Implementation discussion
- Technical results and conclusions

A portfolio excerpt containing the opening portion of the original final technical report is provided to demonstrate the project's system design, architecture, implementation, and technical documentation.

[View the Final Technical Report Portfolio Excerpt](docs/WAV2T-Final-Report-Portfolio-Excerpt.pdf)

> **Documentation Note:** The complete SRS and final technical report are not publicly distributed because WAV2T was developed as a client-based academic project. The portfolio excerpts contain the opening portions of the original documents and are provided for portfolio and educational purposes.

> **Technical Note:** The original capstone report discusses machine learning as part of the adaptive assessment's proposed design. The demonstrated assessment used performance-based adaptive logic, with persistent progress tracking and dynamic question difficulty. ML-based proficiency prediction was explored as a potential extension but was not deployed in the demonstrated prototype.

---

## Technical Architecture and Technologies

The WAV2T prototype explored and incorporated multiple technologies across different portions of the project.

### Web Application and Adaptive Assessment

- Python
- Django
- Django ORM
- Django Administration
- C#
- ASP.NET Core MVC
- ASP.NET Core Identity
- HTML/CSS
- Bootstrap
- Relational data modeling
- User authentication
- Persistent user-progress tracking
- Adaptive assessment logic

### AI Chatbot

- Python
- OpenAI API
- Prompt engineering
- Instructional-content extraction and processing
- AI-assisted question-and-answer generation

### Design and Software Engineering

- Software Requirements Specification development
- UML modeling
- Layered architecture design
- Wireframing
- Requirements engineering
- Client/stakeholder collaboration

### Development and Infrastructure

- Git
- GitHub
- Visual Studio
- Visual Studio Code
- AWS/cloud integration research and prototyping

---

# Team Contributions

WAV2T was completed as a three-student computer science capstone project. Responsibilities were divided across software development, system design, project coordination, AI chatbot development, and standalone frontend prototype development.

Requirements gathering, stakeholder engagement, project planning, and presentations also involved collaborative work.

## Connie Rodriguez — Software Development & System Design

Primary responsibilities included:

- Developed the primary website backend and supporting application functionality
- Developed the adaptive assessment system
- Implemented topic- and difficulty-based assessment logic
- Developed persistent user quiz-progress tracking
- Developed Django models supporting questions, topics, difficulty levels, and individual user progress
- Integrated and configured the Django administrative interface
- Developed authentication and student account functionality
- Developed portions of the website frontend
- Integrated frontend functionality with backend application components
- Created all project wireframes
- Created the project's UML and layered architecture diagrams
- Co-authored the Software Requirements Specification (SRS) with Beth Gallatin
- Authored the final technical report, which was edited by Beth Gallatin
- Participated in stakeholder meetings and requirements gathering
- Participated in technical architecture and system-design decisions
- Researched and prototyped AWS/cloud integration for the proposed system
- Supported application integration and final prototype development

The final capstone presentation demonstrates portions of the adaptive assessment implementation, including Django backend logic, question models, persistent user-progress tracking, difficulty-based question selection, and Django administrative functionality.

---

## Beth Gallatin — Project Coordination & AI Chatbot Development

Primary responsibilities included:

- Coordinated stakeholder communication and project activities
- Co-authored the Software Requirements Specification (SRS) with Connie Rodriguez
- Participated in requirements gathering and stakeholder meetings
- Developed the AI chatbot functionality
- Developed the chatbot content-processing workflow
- Worked with Vets 2 Tech instructional materials as source content for the chatbot
- Developed OpenAI API integration
- Developed prompts used to transform instructional material into chatbot-compatible question-and-answer content
- Contributed to project presentations and prototype development

The final capstone presentation demonstrates portions of the chatbot development workflow, including instructional-content processing, OpenAI API integration, and management of chatbot-related educational material.

---

## John McDurmon — Standalone Frontend Prototype Development

Primary responsibilities included:

- Developed standalone HTML frontend prototypes for the proposed website

The standalone frontend prototypes were developed separately from the application's backend and were not integrated with the adaptive assessment system, authentication, Django administrative functionality, or other application services.

> **Contribution Note:** The public repository contains only a portion of the complete capstone development work. GitHub commit history should not be interpreted as a complete record of project functionality or individual contributions.

---

# Project Presentations

The capstone was developed across multiple academic semesters. Formal presentations provide additional documentation of the system at different stages of development and preserve demonstrations of functionality that is not fully represented in the public repository.

## Midyear Project Presentation

The midyear presentation documents first-semester progress, early development, project planning, and goals established for the following semester.

[Watch the WAV2T Midyear Project Presentation on YouTube](https://www.youtube.com/watch?v=aZDb9-EBKT0&t=14s)

## Final Capstone Presentation

The final presentation documents later-stage development and demonstrates portions of the WAV2T prototype that are not fully preserved in this public repository.

Demonstrated functionality includes:

- Adaptive assessment backend
- Topic-based question organization
- Difficulty-based question selection
- Persistent user quiz-progress tracking
- Django models
- Django administrative content management
- Training-material management
- AI chatbot development
- Instructional-content processing
- OpenAI API integration

[Watch the WAV2T Final Capstone Presentation on YouTube](https://www.youtube.com/watch?v=K3cKRxv1ASk&t=3s)

These presentations should be considered supporting project artifacts alongside the SRS, final technical report, and selected source code preserved in this repository.

---

# Repository Contents & Status

This repository preserves selected artifacts and source files from the original academic project, including portions of:

- ASP.NET Core MVC prototype source code
- Authentication and account-management development
- Application models and services
- Razor views
- Project configuration
- SRS portfolio excerpt
- Final technical report portfolio excerpt
- Capstone presentation materials

The repository is maintained as a portfolio and archival snapshot rather than a complete deployable distribution of WAV2T. Some functionality demonstrated during the capstone, particularly portions of the Django implementation, adaptive assessment, and AI chatbot, is not fully represented in the public source code.

---

# Security and Repository Review

As part of preparing the project for public portfolio use, **Connie Rodriguez performed a security review of the repository and available Git history**.

The review included:

- Scanning available Git history for exposed API keys, tokens, passwords, connection strings, and other potential credentials
- Reviewing publicly committed source files for sensitive configuration information
- Verifying that identified example credentials and configuration values were placeholders rather than active credentials
- Reviewing public project artifacts for sensitive information

This security review was performed after completion of the original academic capstone as part of preparing the repository for public portfolio use.

No active production credentials or client secrets are intentionally included in the public repository.

---

# Academic Recognition

**Computer Science Capstone Award - 2025**  
**Hal and Inge Marcus School of Engineering**  
**Saint Martin's University**

The WAV2T capstone project received the Computer Science Capstone Award in recognition of the team's capstone work.

---

# Disclaimer

This repository is maintained for educational and professional portfolio purposes.

It contains selected artifacts from an academic client project and does not represent an actively deployed or officially supported Saint Martin's University or Washington Vets 2 Tech production system.
