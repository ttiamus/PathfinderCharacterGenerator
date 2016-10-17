# PathfinderCharacterGenerator
This is an API dedicated to storing and retreiving Pathfinder RPG data.
I am following a Command Query Resposibilty Segregation model. Each action has a corresponding request, handler and repository specifically for that request. 

The handler is responsible for any business logic related to the action including validation. A request's handler is also responsible for aggregating data from other handlers to finish populating the resposne. 

The repository is the data access component for the request. The backend is a MongoDB instance hosted by mLab (formerly MongoLab). To interact with Mongo, I am using the C# 2.0 MongoDB driver. All actions are asyncronous following the async/await pattern. 

Models are seperated into 3 classifications.  
1. Request: This is an object that is specific to an action. It contains any parameters related to the request. Even if there are no paramters there needs to be a Request object due to the generic interfaces being used.  
2. Data model: This is the structure of the MongoDB collection. This should not extend out of the Repositories.  
3. Response: This is the data model that will be returned from the controller.

Inside the Core.V2 project, I am trying to keep all classes related to a functional area grouped together instead of in seperate projects. I am still uncertain as to how this architecture will work in the future.
