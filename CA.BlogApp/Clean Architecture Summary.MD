Clean Architecture is a software design approach that separates the software system into layers, each with a specific purpose and responsibility. The main goal of Clean Architecture is to allow for independent development, testing, and deployment of each layer, resulting in a system that is flexible and maintainable.


We can use clean architecture while:

		+ Dependency on infrastructure in minimized keeping focused on domain logic.
		+ Complex business logic warrants highly testable architecture.

Rules of Clean Architecture:

	 - Model all business rules and entities in core project.
	 - All dependencies flow toward the core project.
	 - Inner projects define interfaces while outer projects implements them.


Benefits of Clean Architectures:

	- Provides Testablity making it easier to conduct thorough testing of the system.
	- Easier to make changes in code without directly affecting other modules.
	- Promotes loose coupling.