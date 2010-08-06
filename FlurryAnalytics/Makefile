SOURCESWITHLOCATION = \
	flurryWithLocation.cs		

SOURCES = \
	flurry.cs

all: FlurryWithLocation.dll Flurry.dll

FlurryWithLocation.dll: $(SOURCESWITHLOCATION) 
	/Developer/MonoTouch/usr/bin/btouch -out=FlurryWithLocation.dll flurryWithLocation.cs

Flurry.dll: $(SOURCES)
	/Developer/MonoTouch/usr/bin/btouch -out=Flurry.dll flurry.cs