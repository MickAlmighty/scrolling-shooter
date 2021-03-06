#version 330 core
out vec4 FragColor;

in vec2 TexCoords;
in vec3 Normal;
in vec3 FragPos;
in vec4 FragPosLightSpace;
uniform sampler2D texture_diffuse1;
uniform vec3 lightColor;
uniform bool isFromFile;
void main()
{    
	FragColor = texture(texture_diffuse1, TexCoords) * vec4(1,1,1,1);
}