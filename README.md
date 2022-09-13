# GymOffice.CustomerLogin 
This is for temporary app setting to test and setup login in the client app

## DONE:
- Standard Identity UI
- DB contains 4 roles: Customer, Admin, Receptionist, Coach. New users are registered as Customers
- One page ("Privacy policy") is closed for anonymous users (redirected to Denied page with the links to Login and Register)
- "Privacy Policy" is also opened only for Customers: if a user is logged in but is not a Customer then "Access denied" page is shown
- EmailSender added with SendGrid key in the Windows secret area. This allows user to confirm email and reset password
- Facebook external login service

## TODO:
- Add other external login services (Google, Twitter, MS).
- Privacy policy page (see below)

## Privacy Policy for the Data from Facebook - should include (see https://developers.facebook.com/terms/):
    a. This policy must comply with applicable law and regulations and must accurately and clearly explain what data you are Processing, how you are Processing it, the purposes for which you are Processing it, and how Users may request deletion of that data.
    b. You may only Process Platform Data as clearly described in your privacy policy and in accordance with all applicable law and regulations, these Terms, and all other applicable terms and policies.
    c. You will maintain publicly available links to your privacy policies in the privacy policy field in the settings of your App Dashboard, as well as in any App Store that allows you to do so, if applicable, and ensure the links remain current and up to date. 
    d. Data Security Requirements:
        i. You must always have in effect and maintain administrative, physical, and technical safeguards that do the following:
            1. Meet or exceed industry standards given the sensitivity of the Platform Data;
            2. Comply with applicable law and regulations, including data security and privacy laws, rules, and regulations; and
            3. Are designed to prevent any unauthorized (including in violation of these Terms or any other applicable terms or policies) Processing (including, for the avoidance of doubt, access, destruction, loss, alteration, disclosure, distribution, or compromise) of Platform Data. 
        ii. You must have a publicly available way for people to report security vulnerabilities in your App to you, and you must promptly address identified deficiencies.
        iii. You must not solicit, collect, store, cache, proxy, or use Facebook or Instagram login credentials of other Users.
        iv. You must not transfer or share user IDs or your access token and secret key, except with a Service Provider who helps you build, run, or operate your App. 
    e. Incident Reporting
        i. If any of the following incidents happen, you must promptly, and no later than 24 hours after you become aware of the incident, notify us and provide us with information we request regarding:
            1. Any unauthorized (including in violation of these Terms or any other applicable terms or policies) Processing (including, for the avoidance of doubt, access, destruction, loss, alteration, disclosure, distribution or compromise) of Platform Data; or
            2. Any incidents that are reasonably likely to compromise the security, confidentiality, or integrity of your IT Systems or your Service Provider’s or Sub-Service Provider’s IT Systems. 
        i. You must immediately begin remediation of the incident and reasonably cooperate with us, including by informing us in reasonable detail of the impact of the incident upon Platform Data and corrective actions being taken, and keeping us updated about your compliance with any notification or other requirements under applicable laws and regulations. 

## Privacy policy for Google: 
    See https://developers.google.com/terms/api-services-user-data-policy
